use storev8
go
select name from sysobjects where type ='P'

select type,(case type when 'P' then '存储过程' 
					    when 'TR' then '触发器'
					    when 'FN' then '函数'
					    else '其它' end)name from sysobjects 
where type in('P','TR','FN')
group by type




select type from sysobjects 
--where type in('P','TR')
group by type