namespace Projeto_Web-Lh_Pets_Alunos;

public class Program
{
    public static void main(string[] args) 
    {
        
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            aapp.UseStaticFiles();
            app.MapGet("/index", (HttpContext contexto)=> {
            contexto.Response.Redirect("index.html", false);
            });

                 Banco dba=new Banco();
                    app.MapGet("/listaClientes", (HttpContext contexto) =>{
                    contexto.Response.WriteAsync( dba.GetListaString());
                    });
                 

            app.Run();


    }
}
