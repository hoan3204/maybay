USE SanBay;
GO

CREATE TABLE MayBay (
    MaMB INT PRIMARY KEY IDENTITY(1,1), -- Mã máy bay, tự động tăng
    TenMayBay NVARCHAR(50) NOT NULL,    -- Tên máy bay
    NamSX INT NOT NULL,                 -- Năm sản xuất
    SoGioBay INT NOT NULL               -- Số giờ bay
);
GO
