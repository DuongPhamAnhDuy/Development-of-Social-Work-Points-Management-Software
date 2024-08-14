create database ql_diemCTXHHUIT_2023__2024
go
use ql_diemCTXHHUIT_2023__2024
go
CREATE TABLE SinhVien (
    MaSV INT PRIMARY KEY,
	ho_ten NVARCHAR(100) NOT NULL,
	gioi_tinh NVARCHAR(10),
	ngay_sinh DATE,
	lop NVARCHAR(50)
);
go

CREATE TABLE HoatDong (
    MaHoatDong NVARCHAR(100) PRIMARY KEY,
    TenHoatDong NVARCHAR(500),
	Nhom int,
    MoTa NVARCHAR(1000),
	NgayThamGia datetime,
    DiemMax FLOAT
);
go

CREATE TABLE SinhVienDangKiHoatDong (
    MaSV INT,
    MaHoatDong NVARCHAR(100),
	TenHoatDong NVARCHAR(500),
	ho_ten NVARCHAR(100),
    NgayDangKi DATE,
    PRIMARY KEY (MaSV, MaHoatDong),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaHoatDong) REFERENCES HoatDong(MaHoatDong)
);
go
CREATE TABLE DiemTru (
    ID INT PRIMARY KEY,
    MaHoatDong NVARCHAR(100),
	TenHoatDong NVARCHAR(500),
	LiDo NVARCHAR(100),
    DiemTru FLOAT,
    FOREIGN KEY (MaHoatDong) REFERENCES HoatDong(MaHoatDong)
);
go

CREATE TABLE TinhTongDiem (
    MaSV INT ,
    TongDiem FLOAT,
	ho_ten nvarchar(100),
	KetQua NVARCHAR(10)
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
);
go
CREATE TABLE DiemDanh (
	ID int primary key,
    MaSV INT,
    MaHoatDong NVARCHAR(100),
	ho_ten NVARCHAR(100),
    DaCoMat Bit,
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaHoatDong) REFERENCES HoatDong(MaHoatDong)
);


INSERT INTO SinhVien
VALUES
  (2001200301, N'Dương Phạm Anh Duy', 'Nam', '2002-3-19', '11DHTH6'),
  (2001200302, N'Phạm Nguyễn Hưng ', 'Nam', '2002-3-18', '11DHTH6'),
  (2001200303, N'Lê Sĩ Hoàng', 'Nam', '2002-3-17', '11DHTH5'),
  (2001200304, N'Lê Hoàng Huy Đào', 'Nam', '2002-3-16', '11DHTH5'),
  (2001200305, N'Đàm Lâm Bảo Ngọc', 'Nam', '2002-3-15', '11DHTH6'),
  (2001200306, N'Đặng Quốc Thắng', 'Nam', '2002-3-14', '11DHTH5'),
  (2001200307, N'Nguyễn Thông Thái', 'Nam', '2002-3-13', '11DHTH9'),
  (2001200308, N'Trần Phương Bích Thảo', N'Nữ', '2002-3-12', '11DHTQ2'),
  (2001200309, N'Trần Thị Phương Thanh', N'Nữ', '2002-3-11', '11DHTQ3'),
  (2001200310, N'Trần Thị Thảo Như', N'Nữ', '2002-3-9', '11DHTQ4'),
  (2001200311, N'Lê Thị Phương Thanh', N'Nữ','2002-3-10', '11DHTQ10'),
  (2001200312, N'Nguyễn Ngọc Thư', N'Nữ','2002-3-8', '11DHTQ9'),
  (2001200313, N'Nguyễn Thị Mỹ Tiên', N'Nữ', '2002-3-8', '11DHTQ5'),
  (2001200314, N'Trần Thị Bé', N'Nữ', '2002-3-7', '11DHTQ7'),
  (2001200315, N'Hồ Ngọc Linh', N'Nữ', '2002-3-6', '11DHTQ6'),
  (2001200316, N'Hồ Hải Huy', 'Nam', '2002-3-5', '11DHBM3'),
  (2001200317, N'Trịnh Hùng Việt', 'Nam', '2002-3-4', '11DHBM4'),
  (2001200318, N'Nguyễn Đông Anh', 'Nam', '2002-3-3', '11DHTQ1'),
  (2001200319, N'Chung Văn Trường', 'Nam', '2002-3-2', '11DHTQ1'),
(2001200320, N'Hoàng Minh Huy', 'Nam', '2002-3-1', '11DHTQ5');
go
INSERT INTO HoatDong VALUES
('I.1', N'Tham gia công tác an ninh trật tự trong sân trường', 1, N'Hỗ trợ phân luồng xe, bố trí xe trên sân trường trong giờ cao điểm… và các công việc liên quan theo phân công của P.CTSV & TTGD', '2023-12-12', 10),
('I.2', N'Hỗ trợ về chuyên môn, nghiệp vụ theo yêu cầu của các phòng, đơn vị thuộc Trường', 1, N'Theo phân công công việc của các đơn vị Phòng, Khoa, Trung tâm, Viện', '2023-12-13', 10),
('I.3', N'Hành trình về nguồn', 1, N'Tham quan bảo tàng, địa chỉ đỏ theo kế hoạch tổ chức của Trường, viết bài báo cáo thu hoạch và đạt yêu cầu','2024-2-12', 20),
('I.4', N'Tham gia các hoạt động bảo vệ môi trường như Chủ nhật xanh, Lớp học không rác, Sân trường sạch, đẹp', 1,N'Tham gia làm các công tác vệ sinh môi trường, cảnh quan của trường, lớp các công tác bảo vệ môi trường, tuyên truyền phòng chống dịch bệnh… và các công việc liên quan theo phân công của các phòng, Khoa, trung tâm', '2024-2-12',10),
('I.5',N'Địa Chỉ Đỏ',1,N'Tham gia hoạt đọng địa chỉ đỏ', '2024-2-12', 20),
('II.1', N'Tham gia trực KTX ', 2, N'Theo phân công của Ban quản lý KTX','2024-2-13', 10),
('II.2', N'Hỗ trợ ổn định trật tự khu vực lớp học', 2, N'Kiểm tra đồng phục, đeo thẻ sinh viên và các công việc liên quan theo phân công của P.CTSV & TTGD', '2023-12-17', 10),
('II.3', N'Làm hỗ trợ ổn định trật tự cho các hoạt động có sự phê duyệt của BGH theo yêu cầu của các đơn vị Phòng, Khoa, Trung tâm, Viện thuộc Trường', 2,N'Theo phân công của các đơn vị Phòng, Khoa, Trung tâm, Viện', '2023-12-17',10),
('II.4', N'Tham gia, tư vấn, hướng dẫn thí sinh đăng ký nguyện vọng 2 vào Trường, thí sinh trúng tuyển làm hồ sơ nhập học', 2, N'Theo phân công của Phòng CTSV và TTGD, Phòng Đào tạo và Trung tâm Tuyển sinh và Truyền thông', '2024-2-13',40),
('II.5', N'Tham gia hỗ trợ công tác phục vụ cho các lễ hội, ngày lễ của Nhà trường.', 2, N'Tham gia phục vụ lễ khai giảng, ngày hội việc làm, các ngày lễ lớn của đất nước, của trường… và các công việc liên quan theo phân công của phòng CTSV-TTGD','2024-3-13', 15),
('II.6', N'Tiếp sức mùa thi', 2, N'- Tham gia các đợt hoạt động chủ điểm của chiến dịch (đối với đội hình tại thành phố).- Đảm bảo số ngày tham gia chương trình (theo danh sách điểm danh).- Chấp hành nghiêm chỉnh nội quy, quy định của chương trình- Hoàn thành nhiệm vụ được phân công theo dõi','2024-2-14', 50),
('III.1', N'Mùa hè xanh', 3, N'- Tham gia đội hình chuyên công tác trong chiến dịch
;Tham gia các đợt hoạt động chủ điểm của chiến dịch (đối với đội hình tại thành phố).
; Chấp hành nghiêm chỉnh nội quy, quy định của chiến dịch
; Hoàn thành nhiệm vụ được phân công', '2024-2-12',50),
('III.2', N'Thực hiện hiến máu nhân đạo', 3, N'- Tham gia hiến máu theo thông báo vận động của Trường.- Tham gia hiến máu theo yêu cầu của các cá nhân hoặc tổ chức khác ngoài Trường. (căn cứ theo giấy chứng nhận hiến máu)','2024-2-12', 25),
('III.3', N'Tham gia các hoạt động từ thiện khác ', 3, N'- Tổ chức đi thăm, hỗ trợ, tặng quà gia đình chính sách theo KH được phê duyệt của BCH Đoàn trường.- Tổ chức đến các mái ấm, nhà mở, giúp đỡ trẻ em cơ nhỡ… theo KH được phê duyệt của BCH Đoàn trường','2024-2-11', 10),
('III.4', N'Tham gia đội hình olyhọc, Mác - Lênin ; Đội hình HSSV giỏi nghề;… ', 3, N'Tham gia và đạt giải từ giải khuyến khích trở lên trong các cuộc thi nói trên', '2024-3-11',70),
('III.6', N'Tham gia đội tuyển thể dục thể thao', 3, N'Tham gia đội hình dự thi cấp khối, tỉnh thành, cấp quốc gia, giao lưu trường bạn (theo quyết định thành lập, giấy chứng nhận tham dự do đơn vị tổ chức cấp)','2024-3-11', 70),
('III.7', N'Tham gia đội tuyển thể dục thể thao', 3, N'Tham gia và đạt giải từ HCĐ trở lên', '2024-12-12',70),
('III.8', N'Tham gia hoạt động văn hóa, văn nghệ', 3, N'Tham gia đội hình dự thi cấp khối, tỉnh thành, cấp quốc gia, giao lưu trường bạn (theo quyết định thành lập, giấy chứng nhận tham dự do đơn vị tổ chức cấp);', '2024-4-12',35),
('III.9', N'Tham gia hoạt động văn hóa, văn nghệ', 3, N'Tham gia và đạt giải từ HCĐ trở lên;', '2024-12-12',70),
('III.10', N'Tham gia hoạt động văn hóa, văn nghệ', 3, N'Tham gia đội văn nghệ phục vụ lễ hội, theo yêu cầu của Trường hoặc theo kế hoạch của khoa được BCH Đoàn trường phê duyệt -Tham gia hoạt động văn nghệ, trình diễn thời trang cấp Trường. -Tham gia đạt giải thưởng về văn hóa, văn nghệ do các đơn vị ngoài Trường tổ chức (Căn cứ Giấy khen/ GCN đạt giải do đơn vị tổ chức -Thực hiện các công tác hỗ trợ tổ chức Hội diễn văn nghệ, thể dục thể thao', '2024-12-12',20),
('III.11', N'Tham gia các hoạt động khác', 3, N'- Dũng cảm bắt cướp có giấy chứng nhận của địa phương nơi xảy ra vụ việc.- Tham gia các hoạt động xã hội khác ngoài trường đạt thành tích xuất sắc có giấy khen của địa phương, đơn vị tổ chức cấp.- Trường hợp đặc biệt được Nhà trường khen thưởng đột xuất','2024-12-12', 30);
go
INSERT INTO DiemTru
values
(001,'I.1', N'Tham gia công tác an ninh trật tự trong sân trường',N'Đăng kí mà không tham gia', 10),
(002,'I.2', N'Hỗ trợ về chuyên môn, nghiệp vụ theo yêu cầu của các phòng, đơn vị thuộc Trường', N'Đăng kí mà không tham gia', 10),
(003,'I.3', N'Hành trình về nguồn', N'Đăng kí mà không tham gia', 20),
(004,'I.4', N'Tham gia các hoạt động bảo vệ môi trường như Chủ nhật xanh, Lớp học không rác, Sân trường sạch, đẹp', N'Đăng kí mà không tham gia', 10),
(005,'I.5',N'Địa Chỉ Đỏ',N'Đăng kí mà không tham gia',20),
(006,'II.1', N'Tham gia trực KTX ',N'Đăng kí mà không tham gia', 10),
(007,'II.2', N'Hỗ trợ ổn định trật tự khu vực lớp học', N'Đăng kí mà không tham gia', 10),
(008,'II.3', N'Làm hỗ trợ ổn định trật tự cho các hoạt động có sự phê duyệt của BGH theo yêu cầu của các đơn vị Phòng, Khoa, Trung tâm, Viện thuộc Trường', N'Đăng kí mà không tham gia', 10),
(009,'II.4', N'Tham gia, tư vấn, hướng dẫn thí sinh đăng ký nguyện vọng 2 vào Trường, thí sinh trúng tuyển làm hồ sơ nhập học', N'Đăng kí mà không tham gia', 40),
(010,'II.5', N'Tham gia hỗ trợ công tác phục vụ cho các lễ hội, ngày lễ của Nhà trường.', N'Đăng kí mà không tham gia', 15),
(011,'II.6', N'Tiếp sức mùa thi', N'Đăng kí mà không tham gia', 50),
(012,'III.1', N'Mùa hè xanh', N'Đăng kí mà không tham gia', 50),
(013,'III.2', N'Thực hiện hiến máu nhân đạo', N'Đăng kí mà không tham gia', 25),
(014,'III.3', N'Tham gia các hoạt động từ thiện khác ', N'Đăng kí mà không tham gia', 10),
(015,'III.4', N'Tham gia đội hình olympic: Toán, Vật lý, Tin học, Mác - Lênin ; Đội hình HSSV giỏi nghề;… ', N'Đăng kí mà không tham gia', 35),
(017,'III.6', N'Tham gia đội tuyển thể dục thể thao', N'Đăng kí mà không tham gia', 70),
(018,'III.7', N'Tham gia đội tuyển thể dục thể thao', N'Đăng kí mà không tham gia', 70),
(019,'III.8', N'Tham gia hoạt động văn hóa, văn nghệ', N'Đăng kí mà không tham gia', 35),
(020,'III.9', N'Tham gia hoạt động văn hóa, văn nghệ', N'Đăng kí mà không tham gia', 70),
(021,'III.10', N'Tham gia hoạt động văn hóa, văn nghệ', N'Đăng kí mà không tham gia', 20),
(022,'III.11', N'Tham gia các hoạt động khác', N'Đăng kí mà không tham gia', 30);

go

select * from DiemDanh
select * from SinhVienDangKiHoatDong
ALTER TABLE DiemDanh
ADD ID INT IDENTITY(1,1) PRIMARY KEY; -- Tạo cột ID làm khóa chính và auto-increment

-- Xóa trigger cũ nếu có
DROP TRIGGER IF EXISTS CopyDataToDiemDanh;

-- Tạo lại trigger với cột ID mới

CREATE TRIGGER CopyDataToDiemDanh
ON SinhVienDangKiHoatDong
AFTER INSERT
AS
BEGIN
    -- Insert dữ liệu vào bảng DiemDanh từ bảng SinhVienDangKiHoatDong
    INSERT INTO DiemDanh (ID, MaSV, MaHoatDong, ho_ten)
    SELECT 
        NEXT VALUE FOR seq_diemdanh_id, -- Sử dụng sequence để tăng dần giá trị ID
        inserted.MaSV, 
        inserted.MaHoatDong,
inserted.ho_ten
        
    FROM inserted
END;
CREATE SEQUENCE seq_diemdanh_id
START WITH 1
INCREMENT BY 1;

DROP PROCEDURE IF EXISTS TinhTongDiemProc; -- Xóa procedure cũ nếu tồn tại

create table NguoiDung
(
	MaSV int,
	TaiKhoan Nvarchar(20),
	MatKhau Nvarchar(20),
	PhanQuyen int
	FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
)
go
insert into NguoiDung(TaiKhoan, MatKhau,PhanQuyen) values
('admin','123',0),
('2001200301','123',1),
('2001200302','123',1),
('2001200303','123',1),
('2001200304','123',1),
('2001200304','123',1),
('2001200305','123',1),
('2001200307','123',1),
('2001200308','123',1),
('2001200309','123',1),
('2001200310','123',1),
('2001200311','123',1),
('2001200312','123',1),
('2001200313','123',1),
('2001200314','123',1),
('2001200315','123',1),
('2001200316','123',1),
('2001200317','123',1),
('2001200318','123',1),
('2001200319','123',1),
('2001200320','123',1),
CREATE TRIGGER TaoTaiKhoanTuDong
ON SinhVien
AFTER INSERT
AS
BEGIN
    DECLARE @MaSV int

    -- Lấy các MaSV đã được chèn mới nhất vào bảng SinhVien
    SELECT @MaSV = MaSV
    FROM inserted

    -- Kiểm tra xem MaSV đã tồn tại trong bảng NguoiDung chưa
    IF NOT EXISTS (SELECT 1 FROM NguoiDung WHERE MaSV = @MaSV)
    BEGIN
        -- Thêm thông tin người dùng mới vào bảng NguoiDung
        INSERT INTO NguoiDung (MaSV, TaiKhoan, MatKhau, PhanQuyen)
        VALUES (@MaSV, CONVERT(NVARCHAR(20), @MaSV), '123', 1)
    END
END

select * from NguoiDung
drop PROCEDURE TinhDiemVaTongDiemTheoNhom

CREATE PROCEDURE TinhDiemVaTongDiemTheoNhom
AS
BEGIN
    SELECT 
        sv.MaSV,
        sv.ho_ten,
        SUM(CASE WHEN hd.Nhom = 1 THEN 
                CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END
                ELSE 0 
            END) AS DiemNhom1,
        SUM(CASE WHEN hd.Nhom = 2 THEN 
                CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END
                ELSE 0 
            END) AS DiemNhom2,
        SUM(CASE WHEN hd.Nhom = 3 THEN 
                CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END
                ELSE 0 
            END) AS DiemNhom3,
        SUM(CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END) AS TongDiem,
        CASE 
            WHEN SUM(CASE WHEN hd.Nhom = 1 THEN 
                CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END
                ELSE 0 
                END) >= 50 
                AND SUM(CASE WHEN dd.DaCoMat = '1' THEN hd.DiemMax ELSE -hd.DiemMax END) >= 170 THEN N'Đạt' 
            ELSE N'Không Đạt' 
        END AS KetQua
    FROM 
        SinhVien sv
    INNER JOIN 
        DiemDanh dd ON sv.MaSV = dd.MaSV
    INNER JOIN 
        HoatDong hd ON dd.MaHoatDong = hd.MaHoatDong
    GROUP BY 
        sv.MaSV, sv.ho_ten;
END

select *from SinhVien

 select * from SinhVienDangKiHoatDong where (MaHoatDong = 'I.1')

