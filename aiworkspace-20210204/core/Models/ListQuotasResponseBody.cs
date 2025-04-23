// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned quotas.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The alias of the quota.</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1828233</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>isolate: subscription</description></item>
            /// <item><description>share: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>isolate</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The product code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PAI_isolate: CPU subscription resource groups of PAI</description></item>
            /// <item><description>PAI_share: GPU pay-as-you-go resource groups of PAI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute_share</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota type. Valid value:</para>
            /// <para>PAI: indicates GPU resource groups of MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The quota specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;cu\&quot;:\&quot;11500\&quot;,\&quot;minCu\&quot;:\&quot;2300\&quot;,\&quot;parentId\&quot;:\&quot;0\&quot;}</para>
            /// </summary>
            [NameInMap("Specs")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotasSpecs> Specs { get; set; }
            public class ListQuotasResponseBodyQuotasSpecs : TeaModel {
                /// <summary>
                /// <para>The specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cu</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The specification type. The parameter can be left empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The specification value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11500</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of quotas that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
