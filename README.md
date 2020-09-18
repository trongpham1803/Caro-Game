# GAME CARO ON LAN
- Tên: Phạm Đức Trọng + Phạm Phát Triển
- MSSV:18521541
- Trường: Đại học Công Nghệ Thông Tin - Đại học Quốc gia Thành phố Hồ Chí Minh
- Môn học: Lập trình mạng căn bản

## Mô tả game
- Là một ứng dụng hỗ trợ người chơi có thể giao tiếp với nhau, tạo kết nối giữa hai đối thủ, và luật chơi để dẫn đến chiến thắng.
- Chi tiết chức năng:
	- Đăng ký
	- Đăng nhập
	- Chơi với máy
	- Xin đi lại
	- Đến ngược thời gian
	- Chơi hai người offline
	- Chơi hai người qua mạng LAN
## Sơ đồ phân hệ

![image](https://user-images.githubusercontent.com/59040797/93621606-02168700-fa06-11ea-809d-1af8b56f0d68.png)

## Database
- Sử dụng công cụ quản lý dữ liệu SQL Server Manager
- Khởi tạo database -> lưu trữ thông tin đăng nhập

![image](https://user-images.githubusercontent.com/59040797/93624145-1492bf80-fa0a-11ea-9dca-602e470df712.png)

- Dựa trên table trên ta có chức năng cơ bản như:
	- Thêm một tài khoản
	- Kiểm tra user có tồn tại không
	- Kiểm tra user nào có điểm cao nhất


## Thiết kế giao diện
- Giao diện login

![image](https://user-images.githubusercontent.com/59040797/93620619-7c460c00-fa04-11ea-9587-3d811649ddc6.png)

 	- Người chơi phải nhập tên đăng nhập và mật khẩu của mình để vào màn hình chính chơi game. Nếu không có thì phải đăng ký.
- Giao diện register

![image](https://user-images.githubusercontent.com/59040797/93620978-0ee6ab00-fa05-11ea-8d06-3ff32e435c5f.png)

	- Nhập thông tin đầy đủ để đăng ký 

- Giao diện chính

![image](https://user-images.githubusercontent.com/59040797/93621718-2e320800-fa06-11ea-9198-eb71f9d2018a.png)

- Đây là màn hình chính để chơi game
	- Góc trên phía bên trái là thông tin của người chơi
	- Các nút ở giữa là cách chức năng thông tin
	- Nút dưới góc bên trái là để thoát game
	- Khung trên bên phải là khung chat
	- Các nút ở dưới là thực hiện chức năng trò chơi.
