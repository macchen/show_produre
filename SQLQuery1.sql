use storev8
go
select name from sysobjects where type ='P'

select type,(case type when 'P' then '�洢����' 
					    when 'TR' then '������'
					    when 'FN' then '����'
					    else '����' end)name from sysobjects 
where type in('P','TR','FN')
group by type




select type from sysobjects 
--where type in('P','TR')
group by type