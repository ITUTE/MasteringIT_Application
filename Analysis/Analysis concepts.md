# Analysis Concepts

## Boundary (Giao diện)
#### Admin
1. `Admin1View` : màn hình hiển thị cho Admin ở vòng 1
2. `Admin2View` : màn hình hiển thị cho Admin ở vòng 2
3. `Admin3View` : màn hình hiển thị cho Admin ở vòng 3
4. `Admin4View` : màn hình hiển thị cho Admin ở vòng 4
5. `Admin5View` : màn hình hiển thị cho Admin ở vòng 5

#### User
1. `Round1View` : màn hình hiển thị cho mỗi đội chơi ở vòng 1
2. `Round2View` : màn hình hiển thị cho mỗi đội chơi ở vòng 2
3. `Round3View` : màn hình hiển thị cho mỗi đội chơi ở vòng 3
4. `Round4View` : màn hình hiển thị cho mỗi đội chơi ở vòng 4

#### Màn hình chức năng
1. `ManagementView` : màn hình quản lý các vòng chơi và điểm cho các đội chơi
2. `HomeView` : màn hỉnh chính của ứng dụng
3. `NotificationView` : màn hình chuyên dùng để hiển thị tất cả các thông báo trong ứng dụng

## Entity (Thực thể)
1. `Team` : chứa thông tin về đội chơi
2. `Round` : chứa thông tin về vòng thi
3. `Question` : chứa thông tin về câu hỏi
4. `Testcase` : chứa thông tin về test case
5. `Answer` : chứa thông tin về câu trả lời
6. `Shape` : chứa thông tin về hình dạng trong sơ đồ khối (flowchart)
7. `AnswerTest` : chứa thông tin về câu trả lời ứng với mỗi test case

## Controller
1. `DbController` : dùng để giao tiếp với CSDL
2. `Round1Controller` : dùng cho vòng 1
3. `Round2Controller` : dùng cho vòng 2
4. `Round3Controller` : dùng cho vòng 3
5. `Round4Controller` : dùng cho vòng 4