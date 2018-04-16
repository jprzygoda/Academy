create table Student(
Name varchar(50) not null,
Surname varchar(50) not null,
Email varchar(50),
Phone int,
PassportNumber varchar(50),
Citizenship varchar(30),
CityOfBirth varchar(30),
YearOfBirth int,
Faculty varchar(50),
IndexNumber int primary key,
YearOfRegistration int,
Photo varchar(50)
);

create table Semester(
SemesterNumber int not null,
StudentsIndexNumber int not null primary key,
foreign key (StudentsIndexNumber) references Student(IndexNumber)
);

create table Assessment(
	AssessmentName varchar(50),
	StudentsIndexNumber int,
	SubjectID int,
	foreign key (StudentsIndexNumber) references Student(IndexNumber),
	foreign key (SubjectID) references Subject(SubjectID)
);

create table Teacher(
	ID int not null primary key,
	Name varchar(50),
	Surname varchar(50) not null,
	DepartmentID int
	foreign key (DepartmentID) references Department(DepartmentNumber)
);

create table Subject(
	SubjectID int not null primary key,
	SubjectName varchar(40) not null,
	TeacherID int,
	foreign key (TeacherID) references Teacher(ID)
);

create table Department(
	DepartmentNumber int not null primary key,
	DepartmentName varchar(50) not null
);
