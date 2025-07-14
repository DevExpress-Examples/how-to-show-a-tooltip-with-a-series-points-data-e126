<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575532/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E126)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Chart – Display Data Source Values in Crosshair Labels

This example displays values from the underlying data source within crosshair labels in a WinForms Chart. When a user hovers over a chart element, the crosshair cursor appears and shows relevant data source values for the selected point. This feature allows users to explore precise data without additional tooltips or legend lookups.

<img width="632" height="393" alt="Display Data Source Values in Crosshair Labels - WinForms Chart Control, DevExpress" src="https://github.com/user-attachments/assets/bf823c7d-b0a1-486b-a444-414abfafe2c5" />


## Implementation Details

Use the [CrosshairLabelPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.CrosshairLabelPattern) property to specify a crosshair label pattern:

```csharp
void Form1_Load(object sender, EventArgs e) {
    chartControl1.Series[0].CrosshairLabelPattern = "Unit price: {UnitPrice}\r\n" +
                                                    "Units in stock: {UnitsInStock}\r\n" +
                                                    "Quantity per unit: {QuantityPerUnit}";
}
```

## Files to Review

* [Form1.cs](./CS/CustomInfoInTooltips/Form1.cs) (VB: [Form1.vb](./VB/CustomInfoInTooltips/Form1.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-show-a-tooltip-with-a-series-points-data-e126&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-show-a-tooltip-with-a-series-points-data-e126&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
