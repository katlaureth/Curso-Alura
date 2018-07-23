﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Loja.Migrations
{
    public partial class Incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.CreateTable(
               name: "Produtos",
               columns: table => new
               {
                   ID = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   Categoria = table.Column<string>(nullable: true),
                   Nome = table.Column<string>(nullable: true),
                   Preco = table.Column<double>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Produtos", x => x.ID);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
