// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supported security policies.</para>
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The supported cipher suites.</para>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// <para>The time when the ACL was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-15T07:37:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-secrity</para>
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// <para>The status of the security policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Configuring</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("SecurityPolicyStatus")]
            [Validation(Required=false)]
            public string SecurityPolicyStatus { get; set; }

            /// <summary>
            /// <para>The supported TLS protocol versions.</para>
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSecurityPoliciesResponseBodySecurityPoliciesTags> Tags { get; set; }
            public class ListSecurityPoliciesResponseBodySecurityPoliciesTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
