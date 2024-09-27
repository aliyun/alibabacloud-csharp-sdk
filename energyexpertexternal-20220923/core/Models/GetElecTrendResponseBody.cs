// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetElecTrendResponseBodyData Data { get; set; }
        public class GetElecTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Photoelectricity monthly electricity consumption and carbon emissions and other data.</para>
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataLight> Light { get; set; }
            public class GetElecTrendResponseBodyDataLight : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Solar Power</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.light_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Monthly electricity consumption and carbon emissions data for nuclear power</para>
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataNuclear> Nuclear { get; set; }
            public class GetElecTrendResponseBodyDataNuclear : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The price unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nuclear power</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.nuclear_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Monthly data on renewable electricity consumption and carbon emissions</para>
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataRenewing> Renewing { get; set; }
            public class GetElecTrendResponseBodyDataRenewing : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The price unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Renewable electricity</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.carbonEmissionAnalysis.components.CarbonDetail.lingTanDianLi</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Data such as monthly electricity consumption and carbon emissions from the mains.</para>
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataUrban> Urban { get; set; }
            public class GetElecTrendResponseBodyDataUrban : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The price unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Grid power</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.urban_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Monthly data on electricity consumption and carbon emissions for hydropower.</para>
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataWater> Water { get; set; }
            public class GetElecTrendResponseBodyDataWater : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hydro power</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.water_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Monthly wind power consumption and carbon emission data</para>
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataWind> Wind { get; set; }
            public class GetElecTrendResponseBodyDataWind : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The price unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Wind power</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.wind_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// <para>Zero electricity monthly electricity consumption and carbon emissions and other data.</para>
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataZero> Zero { get; set; }
            public class GetElecTrendResponseBodyDataZero : TeaModel {
                /// <summary>
                /// <para>Carbon emissions</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// <para>The price unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kWh</para>
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>Month</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>Power Type Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zero carbon electricity</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Power Type Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.carbonEmissionAnalysis.components.CarbonDetail.lingTanDianLi</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.14</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// <para>Year</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
