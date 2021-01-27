-- Select satırı, burada * tüm kolonlar demek
-- ANSII standardında çalışıyoruz
-- Select * from Customers 
-- Select ContactName, CompanyName, City from Customers 
Select ContactName Adı, CompanyName ŞirketAdı, City Şehir from Customers 
Select * from Customers where City = 'Berlin'
-- case insensitive - büyük küçük harf duyarlı değil. select, Select, sELeCt farketmez
select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10
select * from Products order by UnitPrice, CategoryID, ProductName
select * from Products order by UnitPrice asc -- ascending, artan
select * from Products order by UnitPrice desc--descending, düşen, azalan
select * from Products where CategoryID=1 order by UnitPrice desc
select count(*) from Products -- tüm satırları say ve satır sayısını ver.
select count(*) Adet from Products where CategoryID=2-- categoryId 2 olan satır sayısını ver. Headeri Adet yap.

Select categoryID from Products group by CategoryID --her bir kategori için grup oluşuyor. 
Select categoryID, count (*) from Products group by CategoryID --hangi kategoride kaç farklı ürün var? tüm kategoriler ayrı ayrı isteniyor
Select categoryID, count (*) from Products group by CategoryID having count(*)<10 --ürün sayısı 10 dan az olan kategorileri listele
Select categoryID, count (*) from Products where UnitPrice>20 
group by CategoryID having count(*)<10 --unitprice 20 den fazla olan, ürün sayısı 10 dan az olan kategorileri listele

select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID --beverages içecek demek :)

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- inner join sadece ikitabloda eşleşenlieri bir araya getirir. eşleşmeyen data varsa onu getirmez.
-- DTO Data Transformation Object // bu joinlere DTO deniyor.

select * from products p inner join [Order Details] od -- order details arasında boşluk olduğu için köşeli parantezde yazıldı.
on p.ProductID = od.ProductID -- p ve od alias, yani takma ad atadık.

select * from products p left join [Order Details] od -- solda olup sağda olmayanları da getir. p de var, od de yok.
on p.ProductID = od.ProductID

select * from Customers c inner join Orders o -- eşleşenler
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o -- solda olup sağda olmayanları da getir. // c de var, o da yok.
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o -- SADECE solda olup sağda olmayanları getir. // c de var, o da yok.
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- null PK (primary key) ya uygulanır

select * from Orders o right join Customers c -- SADECE sağda olup solda olmayanları getir. // c de var, o da yok.
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- null PK (primary key) ya uygulanır

select * from products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderId