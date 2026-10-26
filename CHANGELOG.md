# Changelog

Все заметные изменения в этом проекте будут документироваться в этом файле.

Формат основан на [Keep a Changelog](https://keepachangelog.com/ru/1.1.0/),
проект следует [Semantic Versioning](https://semver.org/lang/ru/).

## [Unreleased]

### Added
- Функция деления с обработкой деления на ноль
- Автоматическое создание релиза через GitHub Actions

### Changed
- Тип возвращаемого значения Divide изменён с double на decimal

### Fixed
- Исправлен конфликт слияния в заголовке Calculator.cs

## [1.0.0] - 2026-10-27

### Added
- Базовый калькулятор с функцией сложения (Add)
- Функция умножения (Multiply)
- Функция деления (Divide)
- Настроен CI через GitHub Actions
- Добавлен .gitignore для C# проектов
- Проведён code review через Pull Requests

### Changed
- Обновлён заголовок файла до "Продвинутый калькулятор v2.0"

### Fixed
- Разрешён конфликт слияния между feature/calculator и feature/calculator-advanced
### Fixed
- Добавлены ограничения на пуши
