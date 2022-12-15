using System;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int number = 10;
double money = 10.5;
bool check = true;
string str = "huy";
// trong c sharp thường có 2 dạng kiểu chính //1 value type ( dạng số ) khoong chua duoc null, 2 la reference type ( chuoiõ, đối tượng ) cho phép null;
string name = null;
// code cu
Nullable<bool> a = null;
//code mới -=> null able
int? b = null;
bool? flag = null;
// ?: => ternarry operator
Console.WriteLine(name != null ? true : false);
// ?=> null conditional operator
// ? dùng sau tên biến, hay đốin tượng
// ? tương tự (!=) nếu cái gì đó khác null thì lấy vế sau
int? length = name?.Length;
//?? => null coalescing operator
//?? tương tự dấu ==, nếu cái gì đó bằng null thì lấy cái vế sau
int? chieudai = name?.Length ?? 10;



