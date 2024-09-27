// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEpdSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Response parameters</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetEpdSummaryResponseBodyData> Data { get; set; }
        public class GetEpdSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Emissions. The result is maintained up to 31 decimal places for precise intermediate calculation and subsequently truncated for display. It is advised to pair the emissions figure with the unit of the environmental impact result for a comprehensive understanding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009.976265540000000000000000000000</para>
            /// </summary>
            [NameInMap("carbonEmission")]
            [Validation(Required=false)]
            public double? CarbonEmission { get; set; }

            /// <summary>
            /// <para>The evaluation index adopted for the environmental impact</para>
            /// 
            /// <b>Example:</b>
            /// <para>GWP100a</para>
            /// </summary>
            [NameInMap("indicator")]
            [Validation(Required=false)]
            public string Indicator { get; set; }

            /// <summary>
            /// <para>The category key. The environmental impact category. Currently, a maximum of 19 categories are supported. Enumeration refers to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gwp</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Calculation method standard</para>
            /// 
            /// <b>Example:</b>
            /// <para>CML v4.8 2016</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>climate change</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Category num: the unique serial number of the environmental impact category. A maximum of 19 categories are supported. Enumeration refers to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// <para>Environmental impact result Value Unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kg CO2-Eq</para>
            /// </summary>
            [NameInMap("preUnit")]
            [Validation(Required=false)]
            public string PreUnit { get; set; }

            /// <summary>
            /// <para>The data status. 1 indicates that the calculation is accurate, 2 indicates that the default data is used, and 3 indicates that the missing factor uses the value of 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public long? State { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B91B5559-065A-55C3-8D75-DA218EBFD1DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
