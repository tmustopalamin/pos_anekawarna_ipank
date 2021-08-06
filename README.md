# pos_anekawarna_ipank
projek lama, aplikasi POS dengan perhitungan rumus material requirement planning

import database dari dbpos.sql ke mysql kamu
connection string ada di Program.cs

jika ada error koneksi database pada saat menjalankan program coba usahakan coneection string benar.
conString = "Server=hostMysqlKamu;Database=dbpos;Uid=userNameMysqlKamu;Pwd=passwordMysqlKamu;";

jika sudah dipastikan dan masih error coba ganti password user root kamu dengan query ini:
> ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'passwordMysqlKamuYangBaru'


