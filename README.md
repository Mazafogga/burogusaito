# burogusaito
markdown blogsite





<!-- init DB -->
sudo -u postgres psql
postgres=# create database db1;
postgres=# create user admin with encrypted password 'admin';
postgres=# grant all privileges on database db1 to admin;

<!-- check DB activity, pool, etc -->
SELECT * FROM pg_stat_activity;
