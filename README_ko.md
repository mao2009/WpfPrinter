# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

WPF용 인쇄 기능을 제공하는 라이브러리입니다.

## 개요

이 라이브러리는 WPF 애플리케이션에서 인쇄 기능을 쉽게 구현하도록 설계되었습니다. 고정 문서 인쇄를 지원하며 방향 설정 등 기본적인 인쇄 옵션을 제공합니다.

## 특징

- WPF FixedDocument 인쇄 지원
- 방향 설정 (세로/가로)
- 인쇄 대화 상자 통합
- 간단한 API

## 설치

```bash
dotnet add package loach.WpfPrinter
```

## 사용법

기본 인쇄 예제:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// 고정 문서 생성
var doc = new FixedDocument();

// 인쇄 실행
ReportPrinter.Print(doc, true, "My Document");
```

### API 참조

#### ReportPrinter.Print

지정된 문서를 인쇄합니다.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**매개변수:**
- `doc`: 인쇄할 FixedDocument
- `isPortrait`: 세로 방향이면 true, 가로 방향이면 false
- `name`: 인쇄 작업 이름

**예외:**
- `ArgumentNullException`: 문서가 null인 경우
- `InvalidOperationException`: 문서가 FixedDocument가 아닌 경우

## 라이선스

이 프로젝트는 MIT 라이선스 하에 제공됩니다. 자세한 내용은 LICENSE 파일을 참조하세요.