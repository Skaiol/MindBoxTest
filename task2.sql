select a.title as 'Тема статьи', t.name as 'Тэг' 
from Article a
left join ArticleTagRelations atr ON atr.articleId = a.id
left join Tag t ON atr.tagId = t.id