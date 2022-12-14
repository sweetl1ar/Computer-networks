# Модель проектирования

## Назначение и состав модели проектирования

Назначение **модели проектирования** заключается в создании полного детализированного описания внутренней архитектуры и алгоритмов работы системы. Рекомендуется разрабатывать данную модель без привязки к конкретным языкам программирования, с помощью которых будет создаваться программный продукт, т.е. разрабатывать логическую модель. Стоит оговориться, что создать модель без оглядки на используемые языки программирования невозможно, но, по крайней мере, необходимо стремиться к этому.

Построение этой модели необходимо:

- для уточнения внутренней архитектуры и вариантов использования системы;
- для уточнения требований;
- для определения детализированных алгоритмов работы системы в целом и ее отдельных элементов.

При разработке модели анализа рекомендуется построить следующие диаграммы:

- классов;
- деятельности.

Основное внимание на данной стадии уделяется проектированию классов (их атрибутов и операций), компоновке классов в подсистемы и определению интерфейсов между классами и подсистемами. Детальное описание операций и взаимодействия между классами выполняется с помощью **диаграмм деятельности**, описывающих алгоритмы работы. В разработке алгоритмов, специфичных для предметной области, непосредственное участие должны принимать эксперты-технологи.

## ДИАГРАММЫ КЛАССОВ

### Назначение и состав диаграммы классов

