begin tran

	create table users
		(usr_id integer not null,
		 username nvarchar(15) not null,
		 pass nvarchar(16) not null,
		 name nvarchar(20) not null,
		 reg_data date,
		 welcome_msg nvarchar(50),
		 no_points integer default 0,
		 type nvarchar(10) not null,
		 primary key  (usr_id)
		);

	create table categories 
		(cat_id integer primary key not null,
		 name nvarchar(20) not null
		);

	create table items 
		(item_id integer primary key not null,
		 name nvarchar(20) not null,
		 cat_id integer,
		 price decimal default 0,
		 points integer default 0,
		 foreign key (cat_id) references categories(cat_id)
		);

	create table groups 
		(gr_id integer primary key not null,
		 name nvarchar(20) not null,
		 descr nvarchar(100),
		);
	create table requests
		(usr_id integer not null,
		 gr_id integer not null,
		 primary key (usr_id, gr_id),
		 foreign key (usr_id) references users(usr_id),
		 foreign key (gr_id)  references groups(gr_id)
		)
	create table user_groups 
		(gr_id integer not null,
		 usr_id integer not null,
		 primary key (gr_id, usr_id),
		 foreign key (gr_id) references groups(gr_id),
		 foreign key (usr_id) references users(usr_id)
		);
commit tran 