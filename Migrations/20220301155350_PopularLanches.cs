using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMAC.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Name,Preco) VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1,'https://cdn.pixabay.com/photo/2018/06/18/20/25/burger-3483290_960_720.jpg', 'https://cdn.pixabay.com/photo/2018/06/18/20/25/burger-3483290_960_720.jpg',0,'Cheese Salada', 12.50) ");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Name,Preco) VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso misto quente com queijo; presunto e queijo de primeira qualidade acompanhado com batata palha',1,'https://2.bp.blogspot.com/-n0BRuB8rVnM/Wwv2pb63PcI/AAAAAAAAM_E/gYTFlGH39zg95nDYtdwPteKhFc8vocccgCLcBGAs/s1600/misto-quente-receita-1.jpeg', 'https://2.bp.blogspot.com/-n0BRuB8rVnM/Wwv2pb63PcI/AAAAAAAAM_E/gYTFlGH39zg95nDYtdwPteKhFc8vocccgCLcBGAs/s1600/misto-quente-receita-1.jpeg',0,'Misto Quente', 8.00) ");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Name,Preco) VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso cheese burguer; presunto e queijo de primeira qualidade',1,'https://s2.glbimg.com/jJirZVMNK5ZsZ9UDLKQBqPu3iXk=/620x455/e.glbimg.com/og/ed/f/original/2020/10/20/hamburgueria_bob_beef_-_dia_das_criancas_-_foto_pfz_studio__norma_lima.jpg', 'https://s2.glbimg.com/jJirZVMNK5ZsZ9UDLKQBqPu3iXk=/620x455/e.glbimg.com/og/ed/f/original/2020/10/20/hamburgueria_bob_beef_-_dia_das_criancas_-_foto_pfz_studio__norma_lima.jpg',0,'Cheese Burguer', 11.00) ");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Name,Preco) VALUES(2, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso Peito de Peru',1,'http://www.padariavianney.com.br/web/image/product.template/3850/image_1024?unique=49a641d', 'http://www.padariavianney.com.br/web/image/product.template/3850/image_1024?unique=49a641d',1,'Lanche Natural Peito Peru', 15.00) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
