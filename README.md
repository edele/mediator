mediator
========
Поведенческий паттерн

Цель: Обеспечивает взаимодействие большой группы объектов разных классов. При этом используя очень слабую связанность и избавляя объекты от необходимости ссылаться друг на друга и знать структуру друг друга.

При этом возникает централизация всей системы, гибкость при добавлении новых классов в систему.

##Структура шаблона

4 блока:
- базовый посредник `Mediator Base`
- базовый коллега `Collegue Base`
- Конкретный посредник `ConcreteMediator`
- Конкретный коллега `Concrete`

**Главная идея** — коллеги ничего не знают о существовании друг друга, но могут обмениваться сообщениями друг с другом или с центром (посредником).

*NB: Медиатор похож на Наблюдателя*

