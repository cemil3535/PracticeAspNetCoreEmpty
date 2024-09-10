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

Controller: Gelen HTTP isteklerini i�leyen ve istemciye cevap g�nderen bir s�n�fd�r. Uygulaman�n i� mant��� ile istemci aras�nda bir ara katman olarak �al���r. Kontrolc�, giri�i al�r, do�rular ve sonra gerekli i�lemleri ger�ekle�tirmek i�in Model'e ge�irir.
Action:  Kontrolc� i�indeki bir y�ntem olup, belirli bir HTTP iste�ini i�ler. Eylemler genellikle bir ActionResult d�ner, bu da bir View, Redirect veya JSON cevab� olabilir.

Model:Uuygulaman�n veri ve i� mant���n� temsil eder. Verilerin depolanmas�, al�nmas� ve de�i�tirilmesi i�in sorumludur. Modeller basit veri aktar�m nesneleri (DTO) veya kendi mant��� olan kompleks varl�klar olabilir.

View: Uygulaman�n kullan�c� aray�z�n� (UI) olu�turan bir �ablonudur. Kontrolc�den veri al�r ve onu UI olu�turmak i�in kullan�r. G�r�n�mler HTML, Razor veya di�er �ablon motorlar� olabilir.

Razor: ASP.NET Core'de HTML g�r�n�mlerini olu�turmak i�in kullan�lan bir �ablon motorudur. C# kodunu do�rudan g�r�n�mlerinizde yazman�za izin verir, b�ylece dinamik verilerin g�r�nt�lenmesini kolayla�t�r�r.

RazorView: Razor �ablon motorunu kullanan �zel bir G�r�n�m t�r�d�r. �n derlenmi� bir g�r�n�m olup, HTML cevaplar�n� olu�turmak i�in kullan�l�r.

wwwroot:  ASP.NET Core uygulamas�nda statik dosyalar�n k�k dizinidir. Resimler, CSS, JavaScript ve HTML dosyalar� gibi web sunucusu taraf�ndan do�rudan servis edilen dosyalar� i�erir.

builder.Build(): WebApplicationBuilder s�n�f�n�n bir �rne�ini olu�turmak i�in kullan�l�r, bu da ASP.NET Core uygulamas�n� yap�land�rmak ve olu�turmak i�in kullan�l�r. WebApplication s�n�f�n�n bir �rne�ini d�ner, bu da uygulamay� ba�latmak i�in kullan�l�r.

app.Run(): ASP.NET Core uygulamas�n� ba�latmak i�in kullan�l�r. Gelen HTTP isteklerini dinlemeye ba�lar ve uygulaman�n i�lem hatt�n� ba�lat�r.

Bu kavramlar birlikte ASP.NET Core uygulamas�n�n temelini olu�turur:

Contoller, gelen istekleri i�ler ve i� mant���n� ger�ekle�tirmek i�in Modellerle etkile�ir.
Modeller, uygulaman�n veri ve i� mant���n� temsil eder.
View, uygulaman�n kullan�c� aray�z�n� olu�turur.
wwwroot, web sunucusu taraf�ndan servis edilen statik dosyalar� i�erir.
builder.Build() uygulamay� yap�land�r�r ve olu�turur, app.Run() uygulamay� ba�lat�r
*/
