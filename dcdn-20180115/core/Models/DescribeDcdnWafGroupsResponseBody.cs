// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of WAF rule groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of WAF rule groups.</para>
        /// </summary>
        [NameInMap("WafGroups")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGroupsResponseBodyWafGroups> WafGroups { get; set; }
        public class DescribeDcdnWafGroupsResponseBodyWafGroups : TeaModel {
            /// <summary>
            /// <para>The time when the WAF rule group was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-12 22:25:11</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the custom WAF rule group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000156</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the WAF rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DCDN-test-operation-reports-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy that is associated with the WAF rule group.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafGroupsResponseBodyWafGroupsPolicies> Policies { get; set; }
            public class DescribeDcdnWafGroupsResponseBodyWafGroupsPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000165</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wasm-testmaster</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>custom</b>: a custom policy</description></item>
                /// <item><description><b>default</b>: the default policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of WAF rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>452</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable subscription. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Subscribe")]
            [Validation(Required=false)]
            public string Subscribe { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1012</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
