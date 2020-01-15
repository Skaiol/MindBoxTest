select p.title, c.title 
from Product p
left join ProductCategoryRelations pcr ON pcr.productId = p.id
left join Category c ON pcr.caregoryId = c.id