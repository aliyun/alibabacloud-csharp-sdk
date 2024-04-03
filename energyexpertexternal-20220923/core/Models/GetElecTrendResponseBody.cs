// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecTrendResponseBody : TeaModel {
        /// <summary>
        /// The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetElecTrendResponseBodyData Data { get; set; }
        public class GetElecTrendResponseBodyData : TeaModel {
            /// <summary>
            /// Photoelectricity monthly electricity consumption and carbon emissions and other data.
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataLight> Light { get; set; }
            public class GetElecTrendResponseBodyDataLight : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power type name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Monthly electricity consumption and carbon emissions data for nuclear power
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataNuclear> Nuclear { get; set; }
            public class GetElecTrendResponseBodyDataNuclear : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The price unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Monthly data on renewable electricity consumption and carbon emissions
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataRenewing> Renewing { get; set; }
            public class GetElecTrendResponseBodyDataRenewing : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The price unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Data such as monthly electricity consumption and carbon emissions from the mains.
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataUrban> Urban { get; set; }
            public class GetElecTrendResponseBodyDataUrban : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The price unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Monthly data on electricity consumption and carbon emissions for hydropower.
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataWater> Water { get; set; }
            public class GetElecTrendResponseBodyDataWater : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e. 50%).
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Monthly wind power consumption and carbon emission data
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataWind> Wind { get; set; }
            public class GetElecTrendResponseBodyDataWind : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The price unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

            /// <summary>
            /// Zero electricity monthly electricity consumption and carbon emissions and other data.
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public List<GetElecTrendResponseBodyDataZero> Zero { get; set; }
            public class GetElecTrendResponseBodyDataZero : TeaModel {
                /// <summary>
                /// Carbon emissions
                /// </summary>
                [NameInMap("carbonEmissionData")]
                [Validation(Required=false)]
                public double? CarbonEmissionData { get; set; }

                /// <summary>
                /// The price unit.
                /// </summary>
                [NameInMap("dataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// Month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// Power Type Name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Power Type Code
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// Electricity consumption
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

                /// <summary>
                /// Year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public string Year { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
