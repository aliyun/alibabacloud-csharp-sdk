// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource quotas.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The alias of the resource quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认Quota。</para>
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
            /// <item><description><para>isolate: subscription.</para>
            /// </description></item>
            /// <item><description><para>share: pay-as-you-go.</para>
            /// </description></item>
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
            /// <para>The product name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PAI_isolate: a subscription PAI resource group (PAI CPU).</para>
            /// </description></item>
            /// <item><description><para>PAI_share: a pay-as-you-go PAI resource group (PAI GPU).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAI_share</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The type of the resource quota. Valid value:</para>
            /// <para>PAI: a GPU resource group cluster of MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The list of specification descriptions.</para>
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
                /// <para>The type. This parameter can be empty.</para>
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
        /// <para>The number of resource quotas that meet the filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
