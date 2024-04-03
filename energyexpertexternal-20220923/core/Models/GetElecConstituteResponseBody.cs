// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecConstituteResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetElecConstituteResponseBodyData Data { get; set; }
        public class GetElecConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// Photoelectric power consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataLight Light { get; set; }
            public class GetElecConstituteResponseBodyDataLight : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Data on nuclear power consumption and carbon emissions at each enterprise.
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataNuclear Nuclear { get; set; }
            public class GetElecConstituteResponseBodyDataNuclear : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Data on renewable electricity consumption and carbon emissions at each enterprise.
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataRenewing Renewing { get; set; }
            public class GetElecConstituteResponseBodyDataRenewing : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Data on mains power electricity consumption and carbon emission of each enterprise.
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataUrban Urban { get; set; }
            public class GetElecConstituteResponseBodyDataUrban : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Hydropower consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataWater Water { get; set; }
            public class GetElecConstituteResponseBodyDataWater : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Wind power consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataWind Wind { get; set; }
            public class GetElecConstituteResponseBodyDataWind : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

            /// <summary>
            /// Data of zero electricity consumption and carbon emission of each enterprise.
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataZero Zero { get; set; }
            public class GetElecConstituteResponseBodyDataZero : TeaModel {
                /// <summary>
                /// Carbon emission.
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
                /// The name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The unique identifier of name.
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

            }

        }

        /// <summary>
        /// Id of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
