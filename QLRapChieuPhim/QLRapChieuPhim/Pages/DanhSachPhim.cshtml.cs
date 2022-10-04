using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLRapChieuPhim.Models;
using gRPCRapChieuPhim;

namespace QLRapChieuPhim.Pages
{
    public class DanhSachPhimModel : PageModel
    {
        public List<Output.Types.Phim> DanhSachPhim { set; get; } = new List<Output.Types.Phim>();
        public List<Output.Types.TheLoaiPhim> DanhSachTheLoai { set; get; } = new List<Output.Types.TheLoaiPhim>();
        public Output.Types.TheLoaiPhim TheLoaiHienHanh { set; get; } = null;
        [BindProperty(SupportsGet =true)]
        public string Category { set; get; } = "";
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { set; get; } = 1;
        public int PageCount { set; get; } = 1;
        public int PageSize = 20;
        public void OnGet()
        {
            var channel = GrpcChannel.ForAddress(Common.ServiceLink);
            var client = new RapChieuPhim.RapChieuPhimClient(channel);
            var idTheLoai = string.IsNullOrEmpty(Category) || Category == "all" ? 0 : int.Parse(Category);
            Output.Types.Phims phims = client.DanhSachPhimTheoTheLoai(new Input.Types.PhimTheoTheLoai()
            {
                TheLoaiId=idTheLoai,
                CurrentPage=CurrentPage,
                PageSize=PageSize
            });
            var TheLoais = client.DanhSachTheLoai(new Input.Types.Empty());
            var XepHangPhims = client.DanhSachXepHangPhim(new Input.Types.Empty());
            DanhSachTheLoai = TheLoais.Items.ToList();
            if (!string.IsNullOrEmpty(Category) && Category != "all")
            {
                TheLoaiHienHanh = DanhSachTheLoai.FirstOrDefault(t => t.Id.Equals(int.Parse(Category)));
            }
            DanhSachPhim = phims.Items.ToList();
            PageCount = phims.PageCount;
            TheLoaiHienHanh = phims.TheLoaiHienHanh;
            foreach (var phim in DanhSachPhim)
            {
                var dsIDTheLoai = phim.DanhSachTheLoaiId.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var TheLoaiPhim = DanhSachTheLoai.Where(t => dsIDTheLoai.Contains(t.Id.ToString())).ToList();
                if (TheLoaiPhim!=null)
                {
                    foreach (var tl in TheLoaiPhim)
                    {
                        phim.TheLoais.Add(new Output.Types.TheLoaiPhim
                        {
                            Id = tl.Id,
                            Ten = tl.Ten
                        });
                    }
                }
                var Xephang = XepHangPhims.Items.FirstOrDefault(xh => xh.Id.Equals(phim.XepHangPhimId));
                phim.XepHang = Xephang ?? new Output.Types.XepHangPhim();
            }
        }
    }
}
