USE [master]
GO
/****** Object:  Database [HRMSSystems]    Script Date: 12/11/2017 6:55:14 AM ******/
CREATE DATABASE [HRMSSystems]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRMSSystems', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HRMSSystems.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HRMSSystems_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HRMSSystems_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HRMSSystems] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRMSSystems].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HRMSSystems] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HRMSSystems] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HRMSSystems] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HRMSSystems] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HRMSSystems] SET ARITHABORT OFF 
GO
ALTER DATABASE [HRMSSystems] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HRMSSystems] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HRMSSystems] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HRMSSystems] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HRMSSystems] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HRMSSystems] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HRMSSystems] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HRMSSystems] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HRMSSystems] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HRMSSystems] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HRMSSystems] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HRMSSystems] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HRMSSystems] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HRMSSystems] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HRMSSystems] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HRMSSystems] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HRMSSystems] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HRMSSystems] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HRMSSystems] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HRMSSystems] SET  MULTI_USER 
GO
ALTER DATABASE [HRMSSystems] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HRMSSystems] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HRMSSystems] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HRMSSystems] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HRMSSystems]
GO
/****** Object:  StoredProcedure [dbo].[EmpAttendance]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EmpAttendance]
@EmpID int,
@NoOfPresent int,
@NoOfAbsence int,
@Details varchar(max),
@status varchar(50)

as 
begin
if @status='INSERT'
begin
insert into tblEmpAttendance(EmpID,NoOfPresent,NoOfAbsence,Details)values(@EmpID,@NoOfPresent,@NoOfAbsence,@Details)
end
if @status='UPDATE'
begin
update tblEmpAttendance set NoOfPresent=@NoOfPresent,NoOfAbsence=@NoOfAbsence,Details=@Details where EmpID=@EmpID
end
if @status='SELECT'
 Begin
 select EmpID,NoOfPresent,NoOfAbsence,Details from tblEmpAttendance
 End
 if @status='DELETE'
  Begin
  delete from tblEmpAttendance where EmpID=@EmpID
 End
end

GO
/****** Object:  StoredProcedure [dbo].[EmpEmergency]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EmpEmergency]
@EmpID int,
@FName varchar(max),
@ContactNo decimal,
@Relationship varchar(max), 
@SName varchar(max),
@Address varchar(max),
@FName1 varchar(max),
@ContactNo1 decimal,
@Relationship1 varchar(max), 
@SName1 varchar(max),
@Address1 varchar(max),
@status varchar(50)
as 
begin
if @status='INSERT'
begin
insert into tblEmpEmergency values(@EmpID,@FName,@ContactNo,@Relationship,@SName,@Address,@FName1,@ContactNo1,@Relationship1,@SName1,@Address1)
end
if @status='UPDATE'
 Begin
 update tblEmpEmergency set FName=@FName,ContactNo=@ContactNo,Relationship=@Relationship,SName=@SName,Address=@Address,FName1=@FName1,ContactNo1=@ContactNo1,Relationship1=@Relationship1,SName1=@SName1,Address1=@Address1 where EmpID=@EmpID
 End
 if @status='SELECT'
 Begin
 select EmpID,FName,ContactNo,Relationship,SName,Address,FName1,ContactNo1,Relationship1,SName1,Address1 from tblEmpEmergency
 End
 if @status='DELETE'
  Begin
  delete from tblEmpEmergency where EmpID=@EmpID
 End
end

GO
/****** Object:  StoredProcedure [dbo].[EmpPersonal]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EmpPersonal]
@EmpID int,
@EmpName varchar(max),
@Qualification varchar(max),
@DOB date,
@Skills varchar(max), 
@Gender varchar(max), 
@Address varchar(max), 
@ContactNo decimal,
@DOJ date,
@Experience varchar(max), 
@MeritalStatus varchar(max),
@status varchar(50)
AS
Begin
 if @status='INSERT'
 Begin
 insert into tblEmployeePersonal values(@EmpID,@EmpName,@Qualification,@DOB,@Skills,@Gender,@Address,@ContactNo,@DOJ,@Experience,@MeritalStatus)
 End
 
 if @status='SELECT'
 Begin 
 select EmpName,Qualification,DOB,Skills,Gender,Address,ContactNo,DOJ,Experience,MeritalStatus from tblEmployeePersonal where EmpID=@EmpID
 End
 if @status='UPDATE'
 Begin
 update tblEmployeePersonal set EmpName=@EmpName,Qualification=@Qualification,DOB=@DOB,Skills=@Skills,Gender=@Gender,Address=@Address,ContactNo=@ContactNo,DOJ=@DOJ,Experience=@Experience,MeritalStatus=@MeritalStatus where EmpID=@EmpID
 End
  if @status='DELETE'
  Begin
  delete from tblEmployeePersonal where EmpID=@EmpID
 End
End

GO
/****** Object:  StoredProcedure [dbo].[PayBankDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PayBankDetails]
@EmpID int,
@BName varchar(max),
@BBranch varchar(max),
@IFSC varchar(max),
@Address varchar(max),
@AccNo decimal,
@status varchar(50)
as
Begin
 if @status='INSERT'
begin
insert into tblPayBankDetails(EmpID,BName,BBranch,IFSC,Address,AccNo )values(@EmpID,@BName,@BBranch,@IFSC,@Address,@AccNo )
end
if @status='UPDATE'
begin
update tblPayBankDetails set BName=@BName,BBranch=@BBranch,IFSC=@IFSC,Address=@Address,AccNo=@AccNo where EmpID=@EmpID 
end
if @status='SELECT'
 Begin
 select EmpID,BName,BBranch,IFSC,Address,AccNo  from tblPayBankDetails
 End
 if @status='DELETE'
  Begin
  delete from tblPayBankDetails where EmpID=@EmpID
 End
End

GO
/****** Object:  StoredProcedure [dbo].[PayReport]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PayReport]
@EmpID int,
@Training varchar(max),
@pay float,
@personal varchar(max),
@status varchar(50)
as 
begin
if @status='INSERT'
begin
insert into tblPayReport(EmpID,Training,pay,personal)values(@EmpID,@Training,@pay,@personal)
end
if @status='UPDATE'
begin
update tblPayReport set Training=@Training,pay=@pay,personal=@personal where EmpID=@EmpID 
end
if @status='SELECT'
 Begin
 select EmpID,Training,pay,personal from tblPayReport
 End
 if @status='DELETE'
  Begin
  delete from tblPayReport where EmpID=@EmpID
 End
end

GO
/****** Object:  StoredProcedure [dbo].[PaySalaryDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PaySalaryDetails]
@EmpID int,
@Designation varchar(max),
@Salary float,
@Payscale varchar(max),
@status varchar(50)
as 
begin
 if @status='INSERT'
begin
insert into tblPaySalaryDetails(EmpID,Designation,Salary,Payscale)values(@EmpID,@Designation,@Salary,@Payscale)
end
if @status='UPDATE'
begin
update tblPaySalaryDetails set Designation=@Designation,Salary=@Salary,Payscale=@Payscale where EmpID=@EmpID 
end
if @status='SELECT'
 Begin
 select EmpID,Designation,Salary,Payscale from tblPaySalaryDetails
 End
 if @status='DELETE'
  Begin
  delete from tblPaySalaryDetails where EmpID=@EmpID
 End
end

GO
/****** Object:  StoredProcedure [dbo].[sp_tblEmpdependent]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_tblEmpdependent]
@EmpID int,
@FatherName varchar(max),
@FcontactNo decimal(18,0), 
@MotherName varchar(max),
@McontactNO varchar(max),
@partnerName varchar(max),
@PartenerNO varchar(max),
@childname varchar(max),
@contectNO decimal(18,0),
@status varchar(50)
as 

if @status='INSERT'
begin
insert into tblEmpdependent values(@EmpID,@FatherName,@FcontactNo,@MotherName,@McontactNO,@partnerName,@PartenerNo,@childName,@contectNO)
end
GO
/****** Object:  StoredProcedure [dbo].[trainingCertificate]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[trainingCertificate]
@EmpID int,
@CandidateId int,
@Cource varchar(max),
@AddDetails varchar(max),
@status varchar(50)
as
 begin
 if @status='INSERT'
begin
 insert into tblTraingCertificate(EmpID,CandidateId,Cource,AddDetails)values(@EmpID,@CandidateId,@Cource,@AddDetails)
 end
 if @status='UPDATE'
begin
update tblTraingCertificate set Cource=@Cource,AddDetails=@AddDetails where EmpID=@EmpID
end
if @status='SELECT'
 Begin
 select EmpID,CandidateId,Cource,AddDetails from tblTraingCertificate
 End
 if @status='DELETE'
  Begin
  delete from tblTraingCertificate where EmpID=@EmpID
 End
 end

GO
/****** Object:  StoredProcedure [dbo].[trainingDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[trainingDetails]
@CandidateId int,
@EmpID int,
@Location varchar(max),
@Duration varchar(max),
@provider varchar(max),
@status varchar(50)
as 
begin
if @status='INSERT'
begin
insert into tblTrainingDetails(EmpID,CandidateId,Location,Duration,provider)values(@EmpID,@CandidateId,@Location,@Duration,@provider)
end
if @status='UPDATE'
begin
update tblTrainingDetails set CandidateId=@CandidateId,Location=@Location,Duration=@Duration,provider=@provider where EmpID=@EmpID
end
if @status='SELECT'
 Begin
 select EmpID,CandidateId,Location,Duration,provider from tblTrainingDetails
 End
 if @status='DELETE'
  Begin
  delete from tblTrainingDetails where EmpID=@EmpID
 End
end

GO
/****** Object:  Table [dbo].[tblEmpAttendance]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmpAttendance](
	[EmpID] [int] NOT NULL,
	[NoOfPresent] [int] NULL,
	[NoOfAbsence] [int] NULL,
	[Details] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmpdependent]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmpdependent](
	[EmpID] [int] NOT NULL,
	[FatherName] [varchar](max) NULL,
	[FcontactNo] [decimal](18, 0) NULL,
	[MotherName] [varchar](max) NULL,
	[McontactNo] [decimal](18, 0) NULL,
	[partnerName] [varchar](max) NULL,
	[PartnerNo] [decimal](18, 0) NULL,
	[childname] [varchar](50) NULL,
	[contectno] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmpEmergency]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmpEmergency](
	[EmpID] [int] NOT NULL,
	[FName] [varchar](max) NULL,
	[ContactNo] [decimal](18, 0) NULL,
	[Relationship] [varchar](max) NULL,
	[SName] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[FName1] [varchar](max) NULL,
	[ContactNo1] [decimal](18, 0) NULL,
	[Relationship1] [varchar](max) NULL,
	[SName1] [varchar](max) NULL,
	[Address1] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployeePersonal]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployeePersonal](
	[EmpID] [int] NOT NULL,
	[EmpName] [varchar](max) NULL,
	[Qualification] [varchar](max) NULL,
	[DOB] [date] NULL,
	[Skills] [varchar](max) NULL,
	[Gender] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[ContactNo] [decimal](18, 0) NULL,
	[DOJ] [date] NULL,
	[Experience] [varchar](max) NULL,
	[MeritalStatus] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPayBankDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPayBankDetails](
	[EmpID] [int] NOT NULL,
	[BName] [varchar](max) NULL,
	[BBranch] [varchar](max) NULL,
	[IFSC] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[AccNo] [decimal](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPayReport]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPayReport](
	[EmpID] [int] NOT NULL,
	[Training] [varchar](max) NULL,
	[pay] [float] NULL,
	[personal] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPaySalaryDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPaySalaryDetails](
	[EmpID] [int] NOT NULL,
	[Designation] [varchar](max) NULL,
	[Salary] [float] NULL,
	[Payscale] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTraingCertificate]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTraingCertificate](
	[CandidateId] [int] NOT NULL,
	[EmpID] [int] NOT NULL,
	[Cource] [varchar](max) NULL,
	[AddDetails] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTrainingDetails]    Script Date: 12/11/2017 6:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTrainingDetails](
	[CandidateId] [int] NOT NULL,
	[EmpID] [int] NOT NULL,
	[Location] [varchar](max) NULL,
	[Duration] [varchar](max) NULL,
	[provider] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CandidateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblEmpAttendance] ([EmpID], [NoOfPresent], [NoOfAbsence], [Details]) VALUES (98654, 14, 12, N'4521862')
INSERT [dbo].[tblEmpAttendance] ([EmpID], [NoOfPresent], [NoOfAbsence], [Details]) VALUES (1011, 2, 2, N'1236')
INSERT [dbo].[tblEmpAttendance] ([EmpID], [NoOfPresent], [NoOfAbsence], [Details]) VALUES (1311, 12, 12, N'12')
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (98654, N'ploi', CAST(14785 AS Decimal(18, 0)), N'lopm', CAST(14785 AS Decimal(18, 0)), N'mjki', CAST(14522 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (1311, N'mkl', CAST(123 AS Decimal(18, 0)), N'nhj', CAST(123 AS Decimal(18, 0)), N'bgh', CAST(145 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (1311, N'hy', CAST(147 AS Decimal(18, 0)), N'nj', CAST(159 AS Decimal(18, 0)), N'bh', CAST(123 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (7896, N'Vijay', CAST(9448814128 AS Decimal(18, 0)), N'Geeta', CAST(8123977323 AS Decimal(18, 0)), N'Sanjay', CAST(9449182765 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (121, N'mk', CAST(1 AS Decimal(18, 0)), N'nk', CAST(2 AS Decimal(18, 0)), N'nk', CAST(3 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[tblEmpdependent] ([EmpID], [FatherName], [FcontactNo], [MotherName], [McontactNo], [partnerName], [PartnerNo], [childname], [contectno]) VALUES (1, N'suresh', CAST(968574714 AS Decimal(18, 0)), N'mammy', CAST(965847123 AS Decimal(18, 0)), N'guru', CAST(965842145 AS Decimal(18, 0)), N'chilf', 966544414)
INSERT [dbo].[tblEmpEmergency] ([EmpID], [FName], [ContactNo], [Relationship], [SName], [Address], [FName1], [ContactNo1], [Relationship1], [SName1], [Address1]) VALUES (98654, N'loiu', CAST(147852 AS Decimal(18, 0)), N'oiu', N'', N'lop', N'loiu', CAST(125478 AS Decimal(18, 0)), N'pol', N'', N'mnhy')
INSERT [dbo].[tblEmpEmergency] ([EmpID], [FName], [ContactNo], [Relationship], [SName], [Address], [FName1], [ContactNo1], [Relationship1], [SName1], [Address1]) VALUES (1311, N'mk', CAST(12 AS Decimal(18, 0)), N'mk', N'', N'mk', N'lm', CAST(21 AS Decimal(18, 0)), N'mk', N'', N'mk')
INSERT [dbo].[tblEmpEmergency] ([EmpID], [FName], [ContactNo], [Relationship], [SName], [Address], [FName1], [ContactNo1], [Relationship1], [SName1], [Address1]) VALUES (121, N'mk', CAST(12 AS Decimal(18, 0)), N'', N'', N'glb', N'nk', CAST(123 AS Decimal(18, 0)), N'12g', N'', N'Glb')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (1, N'naveen', N'be', CAST(0x0D1A0B00 AS Date), N'c#', N'male', N'bangalore', CAST(7845858596 AS Decimal(18, 0)), CAST(0x4A3C0B00 AS Date), N'2', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (2, N'pradeep', N'be', CAST(0x7D1B0B00 AS Date), N'c#', N'male', N'bangalore', CAST(9954512545 AS Decimal(18, 0)), CAST(0xE23A0B00 AS Date), N'1', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (3, N'akash', N'BA', CAST(0xE71C0B00 AS Date), N'asp', N'Male', N'bangalore', CAST(7845695842 AS Decimal(18, 0)), CAST(0xDE3A0B00 AS Date), N'2', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (5, N'santosh', N'be', CAST(0x2E210B00 AS Date), N'c#', N'male', N'afgsfhfsa', CAST(7845854585 AS Decimal(18, 0)), CAST(0xDB3A0B00 AS Date), N'1', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (7, N'anusha', N'mech', CAST(0x7D1B0B00 AS Date), N'c', N'female', N'bidar', CAST(1234567890 AS Decimal(18, 0)), CAST(0x493C0B00 AS Date), N'2', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (8, N'FGFDFG', N'DG', CAST(0x493C0B00 AS Date), N'RS', N'FDM', N'DFKD', CAST(2344844 AS Decimal(18, 0)), CAST(0x493C0B00 AS Date), N'2', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (14, N'ram', N'be', CAST(0x493C0B00 AS Date), N'c', N'male', N'bangalore', CAST(876476456 AS Decimal(18, 0)), CAST(0x493C0B00 AS Date), N'2', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (21, N'qwe', N'we', CAST(0x4B3C0B00 AS Date), N'c', N'male', N'bangaklore', CAST(4548454548 AS Decimal(18, 0)), CAST(0x7B380B00 AS Date), N'3', N' ')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (32, N'psdf[ds', N's;fsf', CAST(0x413D0B00 AS Date), N'asds', N'Female', N'xzczc', CAST(3523425 AS Decimal(18, 0)), CAST(0x433D0B00 AS Date), N'3', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (52, N'Arshiya', N'M.Tech', CAST(0x513D0B00 AS Date), N'C#', N'Female', N'Glb', CAST(9874563210 AS Decimal(18, 0)), CAST(0x513D0B00 AS Date), N'1', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (55, N'Asma', N'B.E', CAST(0x543D0B00 AS Date), N'C', N'Female', N'Glb', CAST(9369852147 AS Decimal(18, 0)), CAST(0x543D0B00 AS Date), N'Fresher', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (87, N'p', N'o', CAST(0x543D0B00 AS Date), N'i', N'Female', N'j', CAST(123 AS Decimal(18, 0)), CAST(0x543D0B00 AS Date), N'4+ Years', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (88, N'loi', N'mn', CAST(0x543D0B00 AS Date), N'mn', N'Female', N'po', CAST(12135 AS Decimal(18, 0)), CAST(0x543D0B00 AS Date), N'5+ Years', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (111, N'Anusha', N'M.Tech', CAST(0x503D0B00 AS Date), N'C#', N'Female', N'Glb', CAST(6369852147 AS Decimal(18, 0)), CAST(0x503D0B00 AS Date), N'3', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (121, N'Agnel', N'B.E', CAST(0x331E0B00 AS Date), N'C#', N'Male', N'Glb', CAST(123654789 AS Decimal(18, 0)), CAST(0x7B3D0B00 AS Date), N'Fresher', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (147, N'Adhunika', N'B.E', CAST(0x653D0B00 AS Date), N'C#', N'Female', N'Glb', CAST(147852369 AS Decimal(18, 0)), CAST(0x653D0B00 AS Date), N'2years', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (251, N'guyt', N'jtuygh', CAST(0x503D0B00 AS Date), N'C', N'Female', N'bhjgihj', CAST(3214844 AS Decimal(18, 0)), CAST(0x503D0B00 AS Date), N'2', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (666, N'Asma', N'BCA', CAST(0x543D0B00 AS Date), N'C#', N'Female', N'Glb', CAST(5896321 AS Decimal(18, 0)), CAST(0x543D0B00 AS Date), N'1+  Year', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (1011, N'Anusha', N'B.E', CAST(0x583D0B00 AS Date), N'C', N'Female', N'Glb', CAST(21456 AS Decimal(18, 0)), CAST(0x583D0B00 AS Date), N'2.5+ Years', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (1311, N'Adhunika', N'B.E', CAST(0x5F3D0B00 AS Date), N'Java', N'Female', N'Glb', CAST(7406192966 AS Decimal(18, 0)), CAST(0x5F3D0B00 AS Date), N'Fresher', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (2123, N'Anusha', N'M.Tech', CAST(0x513D0B00 AS Date), N'C#', N'Female', N'Glb', CAST(8745963210 AS Decimal(18, 0)), CAST(0x513D0B00 AS Date), N'2', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (2321, N'Ameena', N'M.Tech', CAST(0x503D0B00 AS Date), N'C#', N'Female', N'Jagurathi Colony,
Glb', CAST(7411816030 AS Decimal(18, 0)), CAST(0x503D0B00 AS Date), N'3', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (2365, N'S', N'Mtec', CAST(0x513D0B00 AS Date), N'C', N'Female', N'Glb', CAST(9874563210 AS Decimal(18, 0)), CAST(0x513D0B00 AS Date), N'3', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (7896, N'Kavya', N'B.E', CAST(0xCC150B00 AS Date), N'C#', N'Female', N'Plot No. 24, Jagurathi colony, Ring road, 
Near water tank, Banglore.
Pin code: 560021', CAST(8123977323 AS Decimal(18, 0)), CAST(0xB4360B00 AS Date), N'Fresher', N' Single')
INSERT [dbo].[tblEmployeePersonal] ([EmpID], [EmpName], [Qualification], [DOB], [Skills], [Gender], [Address], [ContactNo], [DOJ], [Experience], [MeritalStatus]) VALUES (98654, N'derft', N'bn', CAST(0x553D0B00 AS Date), N'mnh', N'Female', N'mkl', CAST(23658 AS Decimal(18, 0)), CAST(0x553D0B00 AS Date), N'1+ Year', N' Single')
INSERT [dbo].[tblPayBankDetails] ([EmpID], [BName], [BBranch], [IFSC], [Address], [AccNo]) VALUES (98654, N'mkio', N'mki', N'12365', N'lopk', CAST(1236 AS Decimal(18, 0)))
INSERT [dbo].[tblPayBankDetails] ([EmpID], [BName], [BBranch], [IFSC], [Address], [AccNo]) VALUES (1311, N'mnb', N'bgh', N'123', N'mjk', CAST(123 AS Decimal(18, 0)))
INSERT [dbo].[tblPayBankDetails] ([EmpID], [BName], [BBranch], [IFSC], [Address], [AccNo]) VALUES (1311, N'lko', N'mnn', N'123', N'12', CAST(2335 AS Decimal(18, 0)))
INSERT [dbo].[tblPayBankDetails] ([EmpID], [BName], [BBranch], [IFSC], [Address], [AccNo]) VALUES (1311, N'njm', N'm', N'1', N'm', CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[tblPayReport] ([EmpID], [Training], [pay], [personal]) VALUES (98654, N'mlko', 1236, N'pol')
INSERT [dbo].[tblPayReport] ([EmpID], [Training], [pay], [personal]) VALUES (1311, N'23', 12, N'ml')
INSERT [dbo].[tblPayReport] ([EmpID], [Training], [pay], [personal]) VALUES (1311, N'mk', 36, N'jm')
INSERT [dbo].[tblPayReport] ([EmpID], [Training], [pay], [personal]) VALUES (1311, N'12', 12, N'mk')
INSERT [dbo].[tblPaySalaryDetails] ([EmpID], [Designation], [Salary], [Payscale]) VALUES (98654, N'mkio', 123654, N'1452')
INSERT [dbo].[tblPaySalaryDetails] ([EmpID], [Designation], [Salary], [Payscale]) VALUES (1311, N'l', 13, N'12')
INSERT [dbo].[tblPaySalaryDetails] ([EmpID], [Designation], [Salary], [Payscale]) VALUES (1311, N'l', 36, N'12')
INSERT [dbo].[tblTraingCertificate] ([CandidateId], [EmpID], [Cource], [AddDetails]) VALUES (33, 3, N'loi', N'mnb')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (1, 3, N'bangalore', N'2', N'pradeep')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (20, 2123, N'lo', N'2', N'lo')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (33, 3, N'lop', N'5', N'mlk')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (1113, 1311, N'mn', N'23', N'poi')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (2563, 98654, N'mkio', N'2', N'mkio')
INSERT [dbo].[tblTrainingDetails] ([CandidateId], [EmpID], [Location], [Duration], [provider]) VALUES (12364, 98654, N'mkloi', N'loikuj', N'njuiookk')
ALTER TABLE [dbo].[tblEmpAttendance]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblEmpdependent]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblEmpEmergency]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblPayBankDetails]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblPayReport]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblPaySalaryDetails]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblTraingCertificate]  WITH CHECK ADD FOREIGN KEY([CandidateId])
REFERENCES [dbo].[tblTrainingDetails] ([CandidateId])
GO
ALTER TABLE [dbo].[tblTraingCertificate]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
ALTER TABLE [dbo].[tblTrainingDetails]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblEmployeePersonal] ([EmpID])
GO
USE [master]
GO
ALTER DATABASE [HRMSSystems] SET  READ_WRITE 
GO
