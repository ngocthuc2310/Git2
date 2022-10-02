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
        public List<PhimModel> DanhSachPhim { get; private set; }
        public List<TheLoaiPhimModel> DanhSachTheLoai { get; private set; }
        public List<XepHangPhimModel> DanhSachXepHangPhim { get; private set; }

        [BindProperty(SupportsGet = true)]
        public int TheLoaiId { get; set; }

        public void OnGet()
        {
            var channel = GrpcChannel.ForAddress(Common.ServiceLink);
            var client = new RapChieuPhim.RapChieuPhimClient(channel);

            var responseTheloai = client.DanhSachTheLoai(new Input.Types.Empty());
            var responseXephang = client.DanhSachXepHangPhim(new Input.Types.Empty());

            if (TheLoaiId <= 0) TheLoaiId = responseTheloai.Items[0].Id;

            var input = new Input.Types.PhimTheoTheLoai { TheLoaiId = this.TheLoaiId };
            var response = client.DanhSachPhimTheoTheLoai(input);
            DanhSachPhim = response.Items.Select(phim => new PhimModel
            {
                Id = phim.Id,
                TenPhim = phim.TenPhim,
                TenGoc = phim.TenGoc,
                DanhSachTheLoaiId = phim.DanhSachTheLoaiId,
                DaoDien = phim.DaoDien,
                DienVien = phim.DienVien,
                NgayKhoiChieu = phim.NgayKhoiChieu.ToDateTime(),
                NgonNgu = phim.NgonNgu,
                NhaSanXuat = phim.NhaSanXuat,
                NoiDung = phim.NoiDung,
                NuocSanXuat = phim.NuocSanXuat,
                Poster = phim.Poster,
                ThoiLuong = phim.ThoiLuong,
                Trailer = phim.Trailer,
                XepHangPhimId = phim.XepHangPhimId
            }).ToList();

            
            /*
            foreach(var phim in DanhSachPhim)
            {
                var xephang = responseXephang.DanhSachXepHang.FirstOrDefault(x => x.Id.Equals(phim.XepHangPhimId));
                if (xephang != null)
                    phim.XepHangPhim = new XepHangPhimModel
                    {
                        Id = xephang.Id,
                        KyHieu = xephang.KyHieu,
                        Ten = xephang.Ten
                    };

                var dsTheloais = responseTheloai.DanhSachTheLoai
                                                .Where(x => phim.DanhSachTheLoaiId.Contains("," + x.Id.ToString() + ","))
                                                .Select(x => new TheLoaiPhimModel
                                                {
                                                    Id = x.Id,
                                                    Ten = x.Ten
                                                })
                                                .ToList();
                phim.DanhSachTheLoai = dsTheloais;
            }
            */
            DanhSachTheLoai = responseTheloai.Items
                                            .Select(x => new TheLoaiPhimModel
                                            {
                                                Id = x.Id,
                                                Ten = x.Ten
                                            })
                                            .ToList();
            DanhSachXepHangPhim = responseXephang.Items
                                                .Select(x => new XepHangPhimModel
                                                {
                                                    Id = x.Id,
                                                    KyHieu = x.KyHieu,
                                                    Ten = x.Ten
                                                })
                                                .ToList();
        }
    }
}
