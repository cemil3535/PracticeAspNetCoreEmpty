var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //  Adding the necessary services to enable MVC application features and use both views and controllers.

var app = builder.Build();


app.UseStaticFiles();  // Determining the Use of Static Files

app.UseRouting();  // Routing Configuration

app.UseAuthorization();  // Routing authorization


// Defining default route pattern
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();


/*

Controller: Gelen HTTP isteklerini iþleyen ve istemciye cevap gönderen bir sýnýfdýr. Uygulamanýn iþ mantýðý ile istemci arasýnda bir ara katman olarak çalýþýr. Kontrolcü, giriþi alýr, doðrular ve sonra gerekli iþlemleri gerçekleþtirmek için Model'e geçirir.
Action:  Kontrolcü içindeki bir yöntem olup, belirli bir HTTP isteðini iþler. Eylemler genellikle bir ActionResult döner, bu da bir View, Redirect veya JSON cevabý olabilir.

Model:Uuygulamanýn veri ve iþ mantýðýný temsil eder. Verilerin depolanmasý, alýnmasý ve deðiþtirilmesi için sorumludur. Modeller basit veri aktarým nesneleri (DTO) veya kendi mantýðý olan kompleks varlýklar olabilir.

View: Uygulamanýn kullanýcý arayüzünü (UI) oluþturan bir þablonudur. Kontrolcüden veri alýr ve onu UI oluþturmak için kullanýr. Görünümler HTML, Razor veya diðer þablon motorlarý olabilir.

Razor: ASP.NET Core'de HTML görünümlerini oluþturmak için kullanýlan bir þablon motorudur. C# kodunu doðrudan görünümlerinizde yazmanýza izin verir, böylece dinamik verilerin görüntülenmesini kolaylaþtýrýr.

RazorView: Razor þablon motorunu kullanan özel bir Görünüm türüdür. Ön derlenmiþ bir görünüm olup, HTML cevaplarýný oluþturmak için kullanýlýr.

wwwroot:  ASP.NET Core uygulamasýnda statik dosyalarýn kök dizinidir. Resimler, CSS, JavaScript ve HTML dosyalarý gibi web sunucusu tarafýndan doðrudan servis edilen dosyalarý içerir.

builder.Build(): WebApplicationBuilder sýnýfýnýn bir örneðini oluþturmak için kullanýlýr, bu da ASP.NET Core uygulamasýný yapýlandýrmak ve oluþturmak için kullanýlýr. WebApplication sýnýfýnýn bir örneðini döner, bu da uygulamayý baþlatmak için kullanýlýr.

app.Run(): ASP.NET Core uygulamasýný baþlatmak için kullanýlýr. Gelen HTTP isteklerini dinlemeye baþlar ve uygulamanýn iþlem hattýný baþlatýr.

Bu kavramlar birlikte ASP.NET Core uygulamasýnýn temelini oluþturur:

Contoller, gelen istekleri iþler ve iþ mantýðýný gerçekleþtirmek için Modellerle etkileþir.
Modeller, uygulamanýn veri ve iþ mantýðýný temsil eder.
View, uygulamanýn kullanýcý arayüzünü oluþturur.
wwwroot, web sunucusu tarafýndan servis edilen statik dosyalarý içerir.
builder.Build() uygulamayý yapýlandýrýr ve oluþturur, app.Run() uygulamayý baþlatýr
*/
