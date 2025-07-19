# ConsoleApp30

Bu loyiha C# dasturlash tilida yozilgan bo‘lib, `System.IO` kutubxonasi yordamida fayllar bilan ishlash amaliyotini namoyish etadi. Loyiha quyidagi funksiyalarni bajaradi:

## 📷 Dastur rasmi:

![pic](https://github.com/user-attachments/assets/2ac67874-c7e0-4464-aa9f-6eb694f1cd32)

## 📄 Asosiy imkoniyatlari:

- Fayl yaratish (`File.Create`)
- Faylga matn yozish (`File.WriteAllText`)
- Fayldan matn o‘qish (`File.ReadAllText`)

- Fayl mavjudligini tekshirish (`File.Exists`)
- Faylni o‘chirish (`File.Delete`)
- Fayl haqida quyidagi ma’lumotlarni chiqarish:
  - Fayl nomi
  - To‘liq yo‘li
  - Hajmi (baytlarda)
  - Yaratilgan vaqti

## 📁 Ishlatilgan kutubxonalar:

```csharp
using System;
using System.IO;
