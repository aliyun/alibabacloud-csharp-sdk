// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAcceleratePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListEnterpriseAcceleratePoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListEnterpriseAcceleratePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The acceleration pattern.</para>
            /// <list type="bullet">
            /// <item><description><para><b>whitelist</b>: accelerates access to applications in the whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: accelerates access to all applications.</para>
            /// </description></item>
            /// <item><description><para><b>build-in-list:</b> accelerates access to built-in applications.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("AccelerationType")]
            [Validation(Required=false)]
            public string AccelerationType { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条测试策略。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-eec34d4b12fcca61</para>
            /// </summary>
            [NameInMap("EapId")]
            [Validation(Required=false)]
            public string EapId { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable Transport Layer Security (TLS).</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disable</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnTls")]
            [Validation(Required=false)]
            public int? OnTls { get; set; }

            /// <summary>
            /// <para>The policy priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is visible on the client.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: not visible</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: visible</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShowInClient")]
            [Validation(Required=false)]
            public int? ShowInClient { get; set; }

            /// <summary>
            /// <para>The address of the acceleration instance. The address can be an IP address or a domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.34.56.XX</para>
            /// </summary>
            [NameInMap("UpstreamHost")]
            [Validation(Required=false)]
            public string UpstreamHost { get; set; }

            /// <summary>
            /// <para>The port of the acceleration instance. The port must be between 1000 and 60000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("UpstreamPort")]
            [Validation(Required=false)]
            public int? UpstreamPort { get; set; }

            /// <summary>
            /// <para>The acceleration instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector</para>
            /// </summary>
            [NameInMap("UpstreamType")]
            [Validation(Required=false)]
            public string UpstreamType { get; set; }

            /// <summary>
            /// <para>The user group for acceleration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户组</para>
            /// </summary>
            [NameInMap("UserAttributeGroup")]
            [Validation(Required=false)]
            public string UserAttributeGroup { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB0471D0-C05C-556D-9F40-0325D890036F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
