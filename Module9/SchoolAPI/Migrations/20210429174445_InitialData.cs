using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(maxLength: 60, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });
				
			migrationBuilder.CreateTable(
                name: "UserManagement",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
					password = table.Column<string>(maxLength: 30, nullable: false),
					email = table.Column<string>(maxLength: 30, nullable: false),
					status = table.Column<string>(maxLength: 30, nullable: false),
					SystemRoleId = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("username", x => x.UserName);
                });
				
			migrationBuilder.CreateTable(
                name: "SectionEnrollmentManagement",
                columns: table => new
                {
                    SectionId = table.Column<Guid>(nullable: false),
					UserId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
					StartDate = table.Column<DateTime>(nullable: false),
					EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SectionId", x => x.SectionId);
                });
				
			migrationBuilder.CreateTable(
                name: "CourseManagement",
                columns: table => new
                {
					CourseTitle = table.Column<string>(maxLength: 30, nullable: false)
					description = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CourseTitle", x => x.CourseTitle);
                });
				
			migrationBuilder.CreateTable(
                name: "CourseSectionManagement",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
					StartDate = table.Column<DateTime>(nullable: false),
					EndDate = table.Column<DateTime>(nullable: false),
					CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CourseId", x => x.CourseId);
                });
				
			migrationBuilder.CreateTable(
                name: "AssignmentManagement",
                columns: table => new
                {
                    assignmenttitle = table.Column<Guid>(nullable: false),
					description = table.Column<Guid>(nullable: false),
					CourseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("assignmenttitle", x => x.assignmenttitle);
					table.ForeignKey(
                        name: "FK_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseSectionManagement",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserManagement",
                columns: new[] { "OrganizationId", "City", "Country", "OrgName" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Newark", "USA", "njit" });

            migrationBuilder.InsertData(
                table: "SectionEnrollmentManagement",
                columns: new[] { "SectionId", "UserId", "CreatedDate", "UpdatedDate", "StartDate", "EndDate" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "12333", "wseide", "12/15/2021", "08/23/2021", "09/04/2021", "09/06/2021" });

            migrationBuilder.InsertData(
                table: "CourseManagement",
                columns: new[] { "CourseTitle", "description", "UserId", "CreatedDate", "UpdateDate" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "SportsManagement", "sports", "wseide", "09/04/2021", "09/06/2021" });

            migrationBuilder.InsertData(
                table: "CourseSectionManagement",
                columns: new[] { "CourseId", "StartDate", "EndDate", "CreatedDate", "UpdatedDate" },
		values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "12344", "09/05/2021", "12/15/2021", "08/23/2021", "08/25/2021" }});

            migrationBuilder.InsertData(
                table: "AssignmentManagement",
                columns: new[] { "assignmenttitle" "description", "CourseId" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Module1", "Firstassignment", "12345" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");
        }
			
			migrationBuilder.CreateIndex(
                name: "IX_UserManagement_ID",
                table: "UserManagement",
                column: "username");
        }
		
			migrationBuilder.CreateIndex(
                name: "IX_Users_SectionEnrollment_ID",
                table: "SectionEnrollmentManagement",
                column: "SectionId");
        }
		
			migrationBuilder.CreateIndex(
                name: "IX_Course_Management_ID",
                table: "CourseManagement",
                column: "CourseTitle");
        }
		
			migrationBuilder.CreateIndex(
                name: "IX_Course_Section_)Management_ID",
                table: "CourseSectionManagement",
                column: "CourseId");
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");
				
			migrationBuilder.DropTable(
                name: "UserManagement");
				
			migrationBuilder.DropTable(
                name: "SectionEnrollmentManagement");
				
			migrationBuilder.DropTable(
                name: "CourseManagement");
			
			migrationBuilder.DropTable(
                name: "CourseSectionManagement");
				
			migrationBuilder.DropTable(
                name: "AssignmentManagement");
			
        }
    }
}
