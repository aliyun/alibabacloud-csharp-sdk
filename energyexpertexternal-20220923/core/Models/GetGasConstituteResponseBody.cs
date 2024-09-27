// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGasConstituteResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGasConstituteResponseBodyData> Data { get; set; }
        public class GetGasConstituteResponseBodyData : TeaModel {
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
            /// <para>Gas emissions</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.14</para>
            /// </summary>
            [NameInMap("gasEmissionData")]
            [Validation(Required=false)]
            public double? GasEmissionData { get; set; }

            /// <summary>
            /// <para>Name of gas</para>
            /// 
            /// <b>Example:</b>
            /// <para>CO₂</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Proportion of carbon emissions. Example value: 0.5 (50%)</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

            /// <summary>
            /// <para>Gas Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

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
