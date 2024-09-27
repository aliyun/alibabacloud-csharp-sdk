// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecConstituteResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetElecConstituteResponseBodyData Data { get; set; }
        public class GetElecConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Photoelectric power consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataLight Light { get; set; }
            public class GetElecConstituteResponseBodyDataLight : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>light</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.light_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Data on nuclear power consumption and carbon emissions at each enterprise.</para>
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataNuclear Nuclear { get; set; }
            public class GetElecConstituteResponseBodyDataNuclear : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.3</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nuclear</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
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
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Data on renewable electricity consumption and carbon emissions at each enterprise.</para>
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataRenewing Renewing { get; set; }
            public class GetElecConstituteResponseBodyDataRenewing : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.3</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>renewing</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.carbonEmissionAnalysis.components.CarbonDetail.keZaiShengZiYuan</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.44</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.3</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Data on mains power electricity consumption and carbon emission of each enterprise.</para>
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataUrban Urban { get; set; }
            public class GetElecConstituteResponseBodyDataUrban : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urban</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.urban_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Hydropower consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataWater Water { get; set; }
            public class GetElecConstituteResponseBodyDataWater : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.1</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>water</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>carbonInventory.check.water_electricity</para>
                /// </summary>
                [NameInMap("nameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>Proportion of electricity consumption to all electricity consumption in the month: example value: 0.5 (i. e., 50%)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Wind power consumption and carbon emission data of each enterprise.</para>
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataWind Wind { get; set; }
            public class GetElecConstituteResponseBodyDataWind : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wind</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
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
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

            /// <summary>
            /// <para>Data of zero electricity consumption and carbon emission of each enterprise.</para>
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public GetElecConstituteResponseBodyDataZero Zero { get; set; }
            public class GetElecConstituteResponseBodyDataZero : TeaModel {
                /// <summary>
                /// <para>Carbon emission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zero</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unique identifier of name.</para>
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
                /// <para>0.33</para>
                /// </summary>
                [NameInMap("ratio")]
                [Validation(Required=false)]
                public double? Ratio { get; set; }

                /// <summary>
                /// <para>Electricity consumption</para>
                /// 
                /// <b>Example:</b>
                /// <para>444.3</para>
                /// </summary>
                [NameInMap("rawData")]
                [Validation(Required=false)]
                public double? RawData { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
