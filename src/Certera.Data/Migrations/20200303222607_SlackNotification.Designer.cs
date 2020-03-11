﻿// <auto-generated />
using System;
using Certera.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Certera.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200303222607_SlackNotification")]
    partial class SlackNotification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Certera.Data.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey2")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ApiKey1")
                        .IsUnique();

                    b.HasIndex("ApiKey2")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeAccount", b =>
                {
                    b.Property<long>("AcmeAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcmeAcceptTos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcmeContactEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ApplicationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAcmeStaging")
                        .HasColumnType("INTEGER");

                    b.Property<long>("KeyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AcmeAccountId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("KeyId");

                    b.ToTable("AcmeAccounts");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeCertificate", b =>
                {
                    b.Property<long>("AcmeCertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AcmeAccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey2")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChallengeType")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrCommonName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrCountryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrLocality")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrOrganization")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrOrganizationUnit")
                        .HasColumnType("TEXT");

                    b.Property<string>("CsrState")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<long>("KeyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SANs")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AcmeCertificateId");

                    b.HasIndex("AcmeAccountId");

                    b.HasIndex("ApiKey1")
                        .IsUnique();

                    b.HasIndex("ApiKey2")
                        .IsUnique();

                    b.HasIndex("KeyId");

                    b.HasIndex("Name", "AcmeAccountId")
                        .IsUnique();

                    b.HasIndex("Subject", "AcmeAccountId");

                    b.ToTable("AcmeCertificates");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeOrder", b =>
                {
                    b.Property<long>("AcmeOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AcmeCertificateId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long?>("DomainCertificateId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Errors")
                        .HasColumnType("TEXT");

                    b.Property<int>("InvalidResponseCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RawDataPem")
                        .HasColumnType("TEXT");

                    b.Property<int>("RequestCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("AcmeOrderId");

                    b.HasIndex("AcmeCertificateId");

                    b.HasIndex("DomainCertificateId");

                    b.ToTable("AcmeOrders");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeRequest", b =>
                {
                    b.Property<long>("AcmeRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AcmeOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("KeyAuthorization")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("AcmeRequestId");

                    b.HasIndex("AcmeOrderId");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("AcmeRequests");
                });

            modelBuilder.Entity("Certera.Data.Models.Domain", b =>
                {
                    b.Property<long>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DateLastScanned")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegistrableDomain")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uri")
                        .HasColumnType("TEXT");

                    b.HasKey("DomainId");

                    b.HasIndex("DateLastScanned");

                    b.HasIndex("Uri")
                        .IsUnique();

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("Certera.Data.Models.DomainCertificate", b =>
                {
                    b.Property<long>("DomainCertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CertificateSource")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("IssuerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawData")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrableDomain")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("Thumbprint")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ValidNotAfter")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ValidNotBefore")
                        .HasColumnType("TEXT");

                    b.HasKey("DomainCertificateId");

                    b.ToTable("DomainCertificates");
                });

            modelBuilder.Entity("Certera.Data.Models.DomainCertificateChangeEvent", b =>
                {
                    b.Property<long>("DomainCertificateChangeEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DateProcessed")
                        .HasColumnType("TEXT");

                    b.Property<long>("DomainId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("NewDomainCertificateId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PreviousDomainCertificateId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DomainCertificateChangeEventId");

                    b.HasIndex("DomainId");

                    b.HasIndex("NewDomainCertificateId");

                    b.HasIndex("PreviousDomainCertificateId");

                    b.ToTable("DomainCertificateChangeEvents");
                });

            modelBuilder.Entity("Certera.Data.Models.DomainScan", b =>
                {
                    b.Property<long>("DomainScanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateScan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long?>("DomainCertificateChangeEventId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DomainCertificateId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DomainId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ScanResult")
                        .HasColumnType("TEXT");

                    b.Property<string>("ScanStatus")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ScanSuccess")
                        .HasColumnType("INTEGER");

                    b.HasKey("DomainScanId");

                    b.HasIndex("DomainCertificateChangeEventId");

                    b.HasIndex("DomainCertificateId");

                    b.HasIndex("DomainId");

                    b.ToTable("DomainScans");
                });

            modelBuilder.Entity("Certera.Data.Models.Key", b =>
                {
                    b.Property<long>("KeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiKey2")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateRotationReminder")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RawData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KeyId");

                    b.HasIndex("ApiKey1")
                        .IsUnique();

                    b.HasIndex("ApiKey2")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Certera.Data.Models.KeyHistory", b =>
                {
                    b.Property<long>("KeyHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ApplicationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOperation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("KeyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operation")
                        .HasColumnType("TEXT");

                    b.HasKey("KeyHistoryId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("KeyId");

                    b.ToTable("KeyHistories");
                });

            modelBuilder.Entity("Certera.Data.Models.NotificationSetting", b =>
                {
                    b.Property<long>("NotificationSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcquisitionFailureAlerts")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdditionalRecipients")
                        .HasColumnType("TEXT");

                    b.Property<long>("ApplicationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ChangeAlerts")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlert14Days")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlert1Day")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlert30Days")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlert3Days")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlert7Days")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExpirationAlerts")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SendEmailNotification")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SendSlackNotification")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SlackWebhookUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("NotificationSettingId");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("NotificationSettings");
                });

            modelBuilder.Entity("Certera.Data.Models.Setting", b =>
                {
                    b.Property<long>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Certera.Data.Models.UserConfiguration", b =>
                {
                    b.Property<long>("UserConfigurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ApplicationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserConfigurationId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("UserConfigurations");
                });

            modelBuilder.Entity("Certera.Data.Models.UserNotification", b =>
                {
                    b.Property<long>("UserNotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ApplicationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("DomainCertificateId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NotificationEvent")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserNotificationId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DomainCertificateId");

                    b.HasIndex("NotificationEvent");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("Certera.Data.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Certera.Data.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Certera.Data.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Certera.Data.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Certera.Data.UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Certera.Data.UserToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeAccount", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.Key", "Key")
                        .WithMany("AcmeAccounts")
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeCertificate", b =>
                {
                    b.HasOne("Certera.Data.Models.AcmeAccount", "AcmeAccount")
                        .WithMany("AcmeCertificates")
                        .HasForeignKey("AcmeAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.Key", "Key")
                        .WithMany("AcmeCertificates")
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeOrder", b =>
                {
                    b.HasOne("Certera.Data.Models.AcmeCertificate", "AcmeCertificate")
                        .WithMany("AcmeOrders")
                        .HasForeignKey("AcmeCertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.DomainCertificate", "DomainCertificate")
                        .WithMany()
                        .HasForeignKey("DomainCertificateId");
                });

            modelBuilder.Entity("Certera.Data.Models.AcmeRequest", b =>
                {
                    b.HasOne("Certera.Data.Models.AcmeOrder", "AcmeOrder")
                        .WithMany("AcmeRequests")
                        .HasForeignKey("AcmeOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.DomainCertificateChangeEvent", b =>
                {
                    b.HasOne("Certera.Data.Models.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.DomainCertificate", "NewDomainCertificate")
                        .WithMany()
                        .HasForeignKey("NewDomainCertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.DomainCertificate", "PreviousDomainCertificate")
                        .WithMany()
                        .HasForeignKey("PreviousDomainCertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.DomainScan", b =>
                {
                    b.HasOne("Certera.Data.Models.DomainCertificateChangeEvent", "DomainCertificateChangeEvent")
                        .WithMany()
                        .HasForeignKey("DomainCertificateChangeEventId");

                    b.HasOne("Certera.Data.Models.DomainCertificate", "DomainCertificate")
                        .WithMany()
                        .HasForeignKey("DomainCertificateId");

                    b.HasOne("Certera.Data.Models.Domain", "Domain")
                        .WithMany("DomainScans")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.KeyHistory", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Certera.Data.Models.Key", "Key")
                        .WithMany("KeyHistories")
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.NotificationSetting", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", "ApplicationUser")
                        .WithOne("NotificationSetting")
                        .HasForeignKey("Certera.Data.Models.NotificationSetting", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.UserConfiguration", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("UserConfigurations")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.Models.UserNotification", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.Models.DomainCertificate", "DomainCertificate")
                        .WithMany()
                        .HasForeignKey("DomainCertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.RoleClaim", b =>
                {
                    b.HasOne("Certera.Data.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.UserClaim", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.UserLogin", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.UserRole", b =>
                {
                    b.HasOne("Certera.Data.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Certera.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Certera.Data.UserToken", b =>
                {
                    b.HasOne("Certera.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
