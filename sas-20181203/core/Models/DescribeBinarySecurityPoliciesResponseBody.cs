// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBinarySecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about security policies.</para>
        /// </summary>
        [NameInMap("BinarySecurityPolicies")]
        [Validation(Required=false)]
        public List<DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPolicies> BinarySecurityPolicies { get; set; }
        public class DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The information about clusters.</para>
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPoliciesClusters> Clusters { get; set; }
            public class DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPoliciesClusters : TeaModel {
                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c316702acdf5f45e1a9dc7fc52f21****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The namespaces.</para>
                /// </summary>
                [NameInMap("Namespaces")]
                [Validation(Required=false)]
                public List<string> Namespaces { get; set; }

            }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logtail</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The content of the policy. The value is in the JSON format. A key supports the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>policyMode</b>: the type of the policy. Default value: requireAttestor.</description></item>
            /// <item><description><b>requiredAttestors</b>: the required witnesses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;PolicyMode\&quot;:\&quot;requireAttestor\&quot;,\&quot;RequiredAttestors\&quot;:[\&quot;test-xcs-04-11-hhht\&quot;]}</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public Dictionary<string, object> Policy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b></description></item>
            /// <item><description><b>disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBinarySecurityPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBinarySecurityPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>218</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
