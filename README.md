# 📦 Demirbaş Yönetim Sistemi  
    Inventory Management System

![.NET Core](https://img.shields.io/badge/.NET%20Core-8.0-purple?style=flat&logo=dotnet)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3%20(Lux)-black?style=flat&logo=bootstrap)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Code%20First-blue?style=flat)
![Status](https://img.shields.io/badge/Status-Completed-success)

Manisa Celal Bayar Üniversitesi Yazılım Mühendisliği bölümü kapsamında geliştirilmiş; kurumsal firmalar için uçtan uca envanter takibi, stok yönetimi ve zimmet/konum takibi sağlayan web tabanlı yönetim sistemi.

---

## 🎥 Proje Önizleme (Demo)

> **Projenin çalışır halini aşağıda izleyebilirsiniz:**

https://github.com/user-attachments/assets/21953bc1-1e4a-40f0-b54c-5db453f511de

![Proje Demosu](demo.gif)

---

##  Proje Hakkında

Bu sistem, manuel envanter takibindeki veri kayıplarını önlemek ve stok yönetimini dijitalleştirmek amacıyla tasarlanmıştır. **MVC (Model-View-Controller)** mimarisi üzerine inşa edilmiş olup, kurumsal güvenlik standartlarına (Identity & Role Based Auth) uygundur.

### ✨ Temel Özellikler

* ** Rol Tabanlı Yetkilendirme (RBAC):**
    * **Admin:** Tam yetki (Ekleme, Silme, Güncelleme, Kullanıcı Yönetimi).
    * **User (Personel):** Sadece görüntüleme ve raporlama yetkisi.
* ** Kritik Stok Yönetimi:** Stok adedi **5'in altına düşen** ürünler için otomatik görsel uyarı sistemi.
* ** Konum ve Zimmet Takibi:** Demirbaşların hangi departmanda veya katta (Örn: Yazılım Lab 1, Zemin Kat) olduğunu takip edebilme.
* ** Dinamik Dashboard:** Toplam stok, kategori ve uyarıların görselleştirildiği yönetim paneli.
* ** Modern Arayüz:** Bootstrap 5 (Lux Teması) ile geliştirilmiş responsive tasarım.

---

## 🛠 Teknoloji Yığını (Tech Stack)

| Alan | Teknoloji |
| :--- | :--- |
| **Backend** | C#, ASP.NET Core 8.0 MVC |
| **Veritabanı** | MS SQL Server |
| **ORM** | Entity Framework Core (Code-First) |
| **Frontend** | HTML5, CSS3, Bootstrap 5 (Bootswatch Lux), JavaScript |
| **Araçlar** | Visual Studio 2022, Git, GitHub |

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/nilufereksi/DemirbasYonetim.git](https://github.com/nilufereksi/DemirbasYonetim.git)
    ```

2.  **Veritabanı Ayarları:**
    `appsettings.json` dosyasını açın ve `DefaultConnection` alanını kendi SQL Server bilgilerinize göre düzenleyin.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=.;Database=DemirbasDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

3.  **Veritabanını Oluşturun (Migration):**
    Visual Studio'da **Package Manager Console**'u açın ve şu komutu girin:
    ```bash
    Update-Database
    ```

4.  **Projeyi Başlatın:**
    `F5` tuşuna basın veya terminalden `dotnet run` komutunu çalıştırın.

---

##  Giriş Bilgileri (Varsayılan)

Projeyi test etmek için aşağıdaki hesapları kullanabilirsiniz:

| Rol | Kullanıcı Adı | Şifre | Yetkiler |
| :--- | :--- | :--- | :--- |
| **Admin** | `admin` | `123` | Tam Erişim (CRUD + Silme) |
| **User** | `user` | `123` | Kısıtlı Erişim (Sadece İzleme) |

---

##  Geliştirici

* [GitHub Profilim](https://github.com/nilufereksi)

---
