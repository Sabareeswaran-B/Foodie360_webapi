using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foodie360.Migrations
{
    public partial class initialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "discount",
            //     columns: table => new
            //     {
            //         discount_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         discount_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //         discount_amount = table.Column<int>(type: "int", nullable: false),
            //         max_discount = table.Column<int>(type: "int", nullable: true),
            //         validity = table.Column<int>(type: "int", nullable: false),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_discount", x => x.discount_id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "order_status",
            //     columns: table => new
            //     {
            //         status_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         status_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('Pending')"),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__order_st__3683B531C8CCEADC", x => x.status_id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "product_type",
            //     columns: table => new
            //     {
            //         type_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         type_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //         category = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')"),
            //         servedAs = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__product___2C0005983DDB01FA", x => x.type_id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "store_type",
            //     columns: table => new
            //     {
            //         store_type_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         store_type = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_store_type", x => x.store_type_id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "users",
            //     columns: table => new
            //     {
            //         user_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         user_name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //         reg_no = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //         phone_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
            //         Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         balance = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')"),
            //         user_role = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('user')"),
            //         pass_word = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_users", x => x.user_id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "orders",
            //     columns: table => new
            //     {
            //         order_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         user_id = table.Column<int>(type: "int", nullable: true),
            //         total_price = table.Column<int>(type: "int", nullable: true),
            //         ordered_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')"),
            //         order_status = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_orders", x => x.order_id);
            //         table.ForeignKey(
            //             name: "FK__orders__order_st__59063A47",
            //             column: x => x.order_status,
            //             principalTable: "order_status",
            //             principalColumn: "status_id");
            //         table.ForeignKey(
            //             name: "FK__orders__user_id__4222D4EF",
            //             column: x => x.user_id,
            //             principalTable: "users",
            //             principalColumn: "user_id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "store",
            //     columns: table => new
            //     {
            //         store_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         owner_name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         store_address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         admin_id = table.Column<int>(type: "int", nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')"),
            //         store_name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         store_type = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_store", x => x.store_id);
            //         table.ForeignKey(
            //             name: "FK__store__admin_id__2F10007B",
            //             column: x => x.admin_id,
            //             principalTable: "users",
            //             principalColumn: "user_id");
            //         table.ForeignKey(
            //             name: "FK__store__store_typ__5DCAEF64",
            //             column: x => x.store_type,
            //             principalTable: "store_type",
            //             principalColumn: "store_type_id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "transaction_history",
            //     columns: table => new
            //     {
            //         transaction_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         user_id = table.Column<int>(type: "int", nullable: true),
            //         amount = table.Column<int>(type: "int", nullable: false),
            //         transaction_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //         transaction_status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__transact__85C600AF501D594E", x => x.transaction_id);
            //         table.ForeignKey(
            //             name: "FK__transacti__user___60A75C0F",
            //             column: x => x.user_id,
            //             principalTable: "users",
            //             principalColumn: "user_id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "products",
            //     columns: table => new
            //     {
            //         product_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         product_name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //         quantity_available = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
            //         store_id = table.Column<int>(type: "int", nullable: true),
            //         type_id = table.Column<int>(type: "int", nullable: true),
            //         mrp = table.Column<int>(type: "int", nullable: true),
            //         special_price = table.Column<int>(type: "int", nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')"),
            //         discount_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_products", x => x.product_id);
            //         table.ForeignKey(
            //             name: "FK__products__discou__6754599E",
            //             column: x => x.discount_id,
            //             principalTable: "discount",
            //             principalColumn: "discount_id");
            //         table.ForeignKey(
            //             name: "FK__products__store___38996AB5",
            //             column: x => x.store_id,
            //             principalTable: "store",
            //             principalColumn: "store_id");
            //         table.ForeignKey(
            //             name: "FK__products__type_i__398D8EEE",
            //             column: x => x.type_id,
            //             principalTable: "product_type",
            //             principalColumn: "type_id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "cart",
            //     columns: table => new
            //     {
            //         cart_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         user_id = table.Column<int>(type: "int", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         quantity = table.Column<int>(type: "int", nullable: true),
            //         total_price = table.Column<int>(type: "int", nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_cart", x => x.cart_id);
            //         table.ForeignKey(
            //             name: "FK__cart__product_id__3E52440B",
            //             column: x => x.product_id,
            //             principalTable: "products",
            //             principalColumn: "product_id");
            //         table.ForeignKey(
            //             name: "FK__cart__user_id__3D5E1FD2",
            //             column: x => x.user_id,
            //             principalTable: "users",
            //             principalColumn: "user_id");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "orderedItems",
            //     columns: table => new
            //     {
            //         item_id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         order_id = table.Column<int>(type: "int", nullable: true),
            //         product_id = table.Column<int>(type: "int", nullable: true),
            //         quantity = table.Column<int>(type: "int", nullable: true),
            //         active = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "('true')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__orderedI__52020FDD9A218DC7", x => x.item_id);
            //         table.ForeignKey(
            //             name: "FK__orderedIt__order__45F365D3",
            //             column: x => x.order_id,
            //             principalTable: "orders",
            //             principalColumn: "order_id");
            //         table.ForeignKey(
            //             name: "FK__orderedIt__produ__46E78A0C",
            //             column: x => x.product_id,
            //             principalTable: "products",
            //             principalColumn: "product_id");
            //     });

            migrationBuilder.CreateIndex(
                name: "IX_cart_product_id",
                table: "cart",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_user_id",
                table: "cart",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_orderedItems_order_id",
                table: "orderedItems",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_orderedItems_product_id",
                table: "orderedItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_order_status",
                table: "orders",
                column: "order_status");

            migrationBuilder.CreateIndex(
                name: "IX_orders_user_id",
                table: "orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_discount_id",
                table: "products",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_store_id",
                table: "products",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_type_id",
                table: "products",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_store_admin_id",
                table: "store",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_store_store_type",
                table: "store",
                column: "store_type");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_history_user_id",
                table: "transaction_history",
                column: "user_id");

            // migrationBuilder.CreateIndex(
            //     name: "UQ__users__74039E9C8B7DEE57",
            //     table: "users",
            //     column: "reg_no",
            //     unique: true,
            //     filter: "[reg_no] IS NOT NULL");

            // migrationBuilder.CreateIndex(
            //     name: "UQ__users__7C9273C4659A52B2",
            //     table: "users",
            //     column: "user_name",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "UQ__users__E6BE36DC1CBAF099",
            //     table: "users",
            //     column: "phone_no",
            //     unique: true,
            //     filter: "[phone_no] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "orderedItems");

            migrationBuilder.DropTable(
                name: "transaction_history");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "order_status");

            migrationBuilder.DropTable(
                name: "discount");

            migrationBuilder.DropTable(
                name: "store");

            migrationBuilder.DropTable(
                name: "product_type");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "store_type");
        }
    }
}
