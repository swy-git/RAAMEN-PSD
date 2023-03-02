create table Role(
    [id] int primary key,
    name varchar(50)
);

create table [User](
    Id int primary key,
    Roleid int,
    Username varchar(50),
    Email varchar(50),
    Gender varchar(50),
    [Password] varchar(50),
    foreign key (Roleid) references Role(id)
);

create table Header(
    id int primary key,
    CustomerId int,
    Staffid int,
    [Date] date,
    foreign key (CustomerId) references [User](id)
);


create table Meat(
    id int primary key,
    [name] varchar(50)
);

create table Ramen(
    id int primary key,
    Meatid int,
    [Name] varchar(50),
    Borth varchar(50),
    Price varchar(50),
    foreign key (Meatid) references Meat(id)
);

create table Detail(
    Headerid int,
    Ramenid int,
    Quantity int,
    primary key (Headerid, Ramenid),
    foreign key (Headerid) references Header(id),
    foreign key (Ramenid) references Ramen(id)
);