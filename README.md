****************************
Tersebut Reconnector

Readme & Changelog

by SECTION (Section_another@hotmail.com)

Contact : fb.com/akasection | axection.deviantart.com | akasection.tumblr.com
****************************
Note untuk versi 1.8.xxxx : 
Versi ini adalah FINAL, tidak akan ada pembaharuan fitur, kecuali pembetulan minor bug yang akan diupdate TIDAK BERKALA
di github.com/axection/TersebutReconnector

Terima kasih atas kerjasamanya selama ini menggunakan Tersebut Reconnector, dari versi 1.6 (public), 1.4 (beta), 1.2 (private)
dan 1.0 (tester) 
Tak terasa aplikasi ini sudah masuk tahun ke dua (dan mendekati 2 tahun : 4 bulan riset, 6 bulan evaluasi, dan 1 tahun running)

Mengingat Tersebut kini open source, silahkan modif sendiri sesuai kebutuhan masing-masing apabila ingin digunakan sebagai
reconector Mikrotik, Juniper, atau halaman login lain dari layanan internet lain. Secara umum apabila login tersebut adalah
Cisco Login, Tersebut Reconnector dengan akun Generic seharusnya bisa berjalan dengan baik.

Disclaimer : 
Aplikasi Tersebut Reconnector adalah aplikasi GRATIS dan tidak dipungut biaya. Melakukan praktek Jual-Beli dengan 
aplikasi ini sangat dilarang keras karena bertentangan dengan lisensi GPL (GNU Public License) yang terpantik langsung
dari github. Ditambah, dengan menggunakan Aplikasi Tersebut Reconnector, Developer tidak bertanggungjawab atas kemungkinan
terjadi nya kerusakan PC, sosial maupun kriminal yang disebabkan oleh jalannya aplikasi ini. 

****************************
CHANGELOG :
v.1.8.5236 Build xxxxx
- Merging semua unofficial update 1.7
- Layout baru, dan semua ditambah fitur-fitur baru.
- Pengklasifikasian baru : Ping Configuration, Reconnection Rule, Monitor & Report, Account, Developer
- Fitur baru : Latency Monitor! Fitur inovatif baru yang bisa melihat kesehatan kekuatan sinyal wifi.id secara GRAFIS 
yang tersambung ke laptopmu. Fitur ini diatur dengan kategori Monitor & Report :
- - Number of Samples : Jumlah sampel yang dilakukan oleh Tersebut untuk membuat nilai rata-rata.
- - Latency Display : Metode penampilan latency. Exact berarti menunjukkan ping tepat pada waktunya, Optimized 
menggunakan rumus tertentu untuk mendapatkan kesimpulan nilai ping dari jaringan, Average menggunakan rumus rata-rata 
dari jumlah sampel, dan Off untuk tidak melakukan monitorong Latency.
- Fitur baru : Gateway : Diketahui wifi.id tiap tempat memiliki gateway berbeda-beda. Kolom ini dapat diisi dengan gateway
masing-masing tempat.
- Fitur baru : Login Page : Fitur yang advanced. secara umum halaman login wifi.id Cisco adalah /login.html. apabila
ada halaman login yang berbeda, maka user dapat mengganti alamat halaman loginnya secara manual.
- Fitur Baru & Kompatibilitas : Metode reconnect baru! Menggunakan sistem POST dan GET, membuat reconnect jauh lebih
cepat, tepat dan minim error. Namun Tersebut masih menyediakan metode lama dengan "Use Legacy Reconnect Method", jikalau
user masih suka cara lama :v
- Penambahan beberapa akun baru! Seperti ESIA, Telkom Gift, BandungJuara dan masih banyak lagi.
- Fitur Fenomenal! Presets! Preset bertujuan agar user dapat mengonfigurasi settingan Tersebut dengan template-template
yang sudah ada (in case user bingung harus di setting berapa)
PERUBAHAN MINOR
- Perubahan tulisan-tulisan logging menjadi lebih ramping.
- Pemindahan tombol About menjadi di dalam tab, berdampingan dengan Logging dan Latency Monitor.
- Penambahan link dari SECTION
- Perbaikan toleransi dari reconnect, dimana reconnect terjadi melebihi angka toleransi.
- Tombol Configuration kini di-disable ketika telah diklik.
- Penambahan tulisan-tulisan Verbose Reporting untuk membantu developer.
- Perbaikan bug Legacy Reconnect tidak mau diubah apabila Tersebut tidak di restart.
- Ada fitur apabila Reconnector mengalami galat akibat IP addressing, Reconnector akan dimatikan paksa, namun
akan berusaha dinyalakan kembali setelah 30 detik.
- Memasuki status final dan akan di diskontinyu

v.1.6.5032 Build 30383
- Penambahan fitur baru : Display Latency Size!
Fitur ini bertujuan untuk melihat secara numerik kualitas sambungan wifi.id
Latency akan memberikan indikator hijau-kuning-merah-hitam, dimana hijau menandakan
koneksi aman, dan hitam berarti koneksi terputus.
- Ditambahkan akun baru : *Generic
Akun ini eksperimental, bertujuan untuk menyambung ke akun non wifi.id dimana masih sama-sama
menggunakan Cisco Login. Use with caution!
- Penambahan Hotkeys baru! Tekan Alt-F12 untuk Menjalankan atau Mematikan Tersebut Reconnector, kapanpun.
- Perubahan sistem ping interval : Minimum Ping Interval dan Maximum Ping Interval
Tujuannya adalah apabila program menerima respon lebih cepat, maka interval ping program akan
lebih cepat (Dynamic Ping), namun tidak lebih cepat dari minimum. Maximum menjadi batas timeout.
- Penggantian label "Advanced Config" menjadi Settings.
- Perbaikan minor bug, apabila Tersebut distop lalu distart, akan tidak menampilkan status koneksi
apapun. (Logging Bug)
- Penggantian beberapa tooltip dan Messaging Status (lebih pendek)
- Perbaikan bug yang menyebabkan program crash apabila tersebut.ini memiliki syntax yang salah. (Syntax Bug)
- Perbaikan bug yang menyebabkan program crash apabila IP DHCP wifi.id tidak benar (invalid IP address)
- Perbaikan bug yang menyebabkan program freeze apabila koneksi terlalu lambat (impossible to reconnect)
- Penambahan error handling apabila IP DHCP tidak dapat diraih, maka program otomatis berhenti.
- Perubahan susunan ikon Program apabila Tersebut berjalan (ikon gelap sekarang menggambarkan program
sedang berhenti)
- Pengembalian TTL menjadi 64 (optimization).
- Perubahan sedikit tata letak dan adjustment ukuran.
- Penambahan sedikit kode-kode ga penting biar keliatan keren :v

v.1.5.5015 Build 43092
- Ditambahkan keluarga akun baru : Radnet!
- Perubahan bytesize dari 64 menjadi 1 agar ping lebih "ringan"
- Perubahan TTL dari 64 menjadi 128 (fitting TTL nya wifi.id)
- Reformat akun @wifi.id untuk secara default memasukkan password otomatis (key=123).
- Penambahan beberapa trace tambahan untuk logging to file dan verbose reporting (developer only)
- Perbaikan icon yang menghilang.
- Verbose Reporting sekarang menampilkan latency time tiap ping.
- Pembetulan apabila konfigurasi belum ditemukan, user akan dibimbing untuk mengisi 
konfigurasi terlebih dahulu.

v.1.4.5009 Build 24188
- Update baru seiring dengan perubahan sistem @wifi.id
- Perubahan state dari Closed Release menjadi Public BETA
- Penambahan akun : Flexi, SPIN, Speedy, Telkomsel, free@wifi.id
- Experimental : Logika false detection reconnect baru
- Pencabutan lisensi
- Penambahan tooltip dan About
- Optimasi ukuran file (300kb++ menjadi 280kb)
- Fitur save password

v.1.3.4914 Build 39719
- Revisi Kode untuk @wifi.id
- Penambahan fitur baru : Masukkan Username dan Account Type
- Logika reconnect baru, tanpa disconnection
- Penahanan versi sehingga lisensi Tersebut tetap bisa dipakai di PREMIUM
- Pembenaran fungsi yang menyebabkan program gagal reconnect

v.1.2.4788 Build 1753
- Perbaikan bug serius ketika menggenerate request code, dimana program tidak dapat menggenerate
kode dengan benar untuk komputer berserial ganjil.
- Perbaikan bug dimana lisensi terbaca terlalu panjang.

v.1.2.4787 Build 17065
- Perbaikan bug serius ketika membaca lisensi, dimana memaksa program membaca 0-bytes code.
- Penghapusan referensi DLL yang tidak perlu, menyebabkan program tidak dapat berjalan di Windows 8.

v.1.2.4786 Build 34454
- Penguatan sekuritas
- Public Release
- Perbaikan minor bug

v1.2.4784 Build 35298
- Icon baru dan indikator baru ketika Service Reconnection sedang berjalan atau berhenti.
- Perbaikan bug program yang mencoba me-refresh IP terus sebelum IP DHCP benar-benar didapat.
- Perbaikan layout program dan desain
- Tampilan logging lebih baik dan rinci.
- Perbaikan instalasi Reconnector Service.
- Penambahan kode sampah, junk dan useless biar programnya gede (lol)
- 2013 COY!

v1.1.4768 Build 21506
- Waktu recovery lebih cepat ketika "connection break" terjadi.
- Perbaikan bug reconnect terus menerus ketika IP belum selesai didapat dari DHCP
(infinite Thread loop Bug)
- Perbaikan UI yang terkadang galau (layout bug)
- Perbaikan Crash program ketika program di stop lalu di start kembali. (Crash Bug)
- Penambahan algoritma tertentu untuk kestabilan program.

v1.2 
- aka version 1.0.0 Build 100
- Naik state menjadi beta.
- Penggantian nama dari wifi.id autoreconnection tool menjadi Tersebut Reconnector
- Implementasi Advanced Configuration
- Terdapat pengaturan lebih lanjut untuk mengatur setelan sifat Reconnect program.
- Finalisasi AI
- Implementasi Minimize to Tray
- Penataan letak baru
- Perbaikan bug program yang membuat bluescreen apabila program berjalan terlalu lama akibat
Threading bertumpuk.
- Perbaikan program menjadi galau ketika gagal menyambung free@wifi.id

v1.1
- Masih Alpha
- Implementasi : Logging 
- Improved AI : deteksi free@wifi.id lebih baik.
- Perbaikan Bluescreen ketika program ingin di stop.
- Perbaikan bug untuk kerap beberapa kali alt+tab sendiri.
- Perbaikan bug untuk kerap melakukan login ketika keadaan sudah login (double login bug).
- Perbaikan program yang menyebabkan developer terlihat kurang ganteng (ganteng bug).
- Penyesuaian tata letak baru.

v1.0 
- Alpha state, banyak fitur yang unstable.
- Basic reconnection system (RTO 8x reconnect)
- Instalasi dasar servis Reconnector

