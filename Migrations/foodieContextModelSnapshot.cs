﻿// <auto-generated />
using System;
using Foodie360.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Foodie360.Migrations
{
    [DbContext(typeof(foodieContext))]
    partial class foodieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Foodie360.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cart_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int")
                        .HasColumnName("total_price");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("CartId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("cart", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("discount_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int>("DiscountAmount")
                        .HasColumnType("int")
                        .HasColumnName("discount_amount");

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("discount_name");

                    b.Property<int?>("MaxDiscount")
                        .HasColumnType("int")
                        .HasColumnName("max_discount");

                    b.Property<int>("Validity")
                        .HasColumnType("int")
                        .HasColumnName("validity");

                    b.HasKey("DiscountId");

                    b.ToTable("discount", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("OrderStatus")
                        .HasColumnType("int")
                        .HasColumnName("order_status");

                    b.Property<DateTime?>("OrderedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("ordered_at");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int")
                        .HasColumnName("total_price");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderStatus");

                    b.HasIndex("UserId");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.OrderedItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("item_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("ItemId")
                        .HasName("PK__orderedI__52020FDD9A218DC7");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("orderedItems", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.OrderStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<string>("StatusName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("status_name")
                        .HasDefaultValueSql("('Pending')");

                    b.HasKey("StatusId")
                        .HasName("PK__order_st__3683B531C8CCEADC");

                    b.ToTable("order_status", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("DiscountId")
                        .HasColumnType("int")
                        .HasColumnName("discount_id");

                    b.Property<int?>("Mrp")
                        .HasColumnType("int")
                        .HasColumnName("mrp");

                    b.Property<string>("ProductName")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("product_name");

                    b.Property<int?>("QuantityAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("quantity_available")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SpecialPrice")
                        .HasColumnType("int")
                        .HasColumnName("special_price");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    b.HasKey("ProductId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("StoreId");

                    b.HasIndex("TypeId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.ProductType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("category");

                    b.Property<string>("ServedAs")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("servedAs");

                    b.Property<string>("TypeName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("type_name");

                    b.HasKey("TypeId")
                        .HasName("PK__product___2C0005983DDB01FA");

                    b.ToTable("product_type", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("admin_id");

                    b.Property<string>("OwnerName")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("owner_name");

                    b.Property<string>("StoreAddress")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("store_address");

                    b.Property<string>("StoreName")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("store_name");

                    b.Property<int?>("StoreType")
                        .HasColumnType("int")
                        .HasColumnName("store_type");

                    b.HasKey("StoreId");

                    b.HasIndex("AdminId");

                    b.HasIndex("StoreType");

                    b.ToTable("store", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.StoreType", b =>
                {
                    b.Property<int>("StoreTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("store_type_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreTypeId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<string>("StoreType1")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("store_type");

                    b.HasKey("StoreTypeId");

                    b.ToTable("store_type", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.TransactionHistory", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("transaction_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<string>("TransactionStatus")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("transaction_status");

                    b.Property<string>("TransactionType")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("transaction_type");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("TransactionId")
                        .HasName("PK__transact__85C600AF501D594E");

                    b.HasIndex("UserId");

                    b.ToTable("transaction_history", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Active")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("('true')");

                    b.Property<int?>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("balance")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("pass_word");

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("phone_no");

                    b.Property<string>("RegNo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("reg_no");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("user_name");

                    b.Property<string>("UserRole")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("user_role")
                        .HasDefaultValueSql("('user')");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "RegNo" }, "UQ__users__74039E9C8B7DEE57")
                        .IsUnique()
                        .HasFilter("[reg_no] IS NOT NULL");

                    b.HasIndex(new[] { "UserName" }, "UQ__users__7C9273C4659A52B2")
                        .IsUnique();

                    b.HasIndex(new[] { "PhoneNo" }, "UQ__users__E6BE36DC1CBAF099")
                        .IsUnique()
                        .HasFilter("[phone_no] IS NOT NULL");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Foodie360.Models.Cart", b =>
                {
                    b.HasOne("Foodie360.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__cart__product_id__3E52440B");

                    b.HasOne("Foodie360.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__cart__user_id__3D5E1FD2");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Foodie360.Models.Order", b =>
                {
                    b.HasOne("Foodie360.Models.OrderStatus", "OrderStatusNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatus")
                        .HasConstraintName("FK__orders__order_st__59063A47");

                    b.HasOne("Foodie360.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__orders__user_id__4222D4EF");

                    b.Navigation("OrderStatusNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Foodie360.Models.OrderedItem", b =>
                {
                    b.HasOne("Foodie360.Models.Order", "Order")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__orderedIt__order__45F365D3");

                    b.HasOne("Foodie360.Models.Product", "Product")
                        .WithMany("OrderedItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__orderedIt__produ__46E78A0C");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Foodie360.Models.Product", b =>
                {
                    b.HasOne("Foodie360.Models.Discount", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK__products__discou__6754599E");

                    b.HasOne("Foodie360.Models.Store", "Store")
                        .WithMany("Products")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__products__store___38996AB5");

                    b.HasOne("Foodie360.Models.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK__products__type_i__398D8EEE");

                    b.Navigation("Discount");

                    b.Navigation("Store");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Foodie360.Models.Store", b =>
                {
                    b.HasOne("Foodie360.Models.User", "Admin")
                        .WithMany("Stores")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FK__store__admin_id__2F10007B");

                    b.HasOne("Foodie360.Models.StoreType", "StoreTypeNavigation")
                        .WithMany("Stores")
                        .HasForeignKey("StoreType")
                        .HasConstraintName("FK__store__store_typ__5DCAEF64");

                    b.Navigation("Admin");

                    b.Navigation("StoreTypeNavigation");
                });

            modelBuilder.Entity("Foodie360.Models.TransactionHistory", b =>
                {
                    b.HasOne("Foodie360.Models.User", "User")
                        .WithMany("TransactionHistories")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__transacti__user___60A75C0F");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Foodie360.Models.Discount", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Foodie360.Models.Order", b =>
                {
                    b.Navigation("OrderedItems");
                });

            modelBuilder.Entity("Foodie360.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Foodie360.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderedItems");
                });

            modelBuilder.Entity("Foodie360.Models.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Foodie360.Models.Store", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Foodie360.Models.StoreType", b =>
                {
                    b.Navigation("Stores");
                });

            modelBuilder.Entity("Foodie360.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Stores");

                    b.Navigation("TransactionHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
