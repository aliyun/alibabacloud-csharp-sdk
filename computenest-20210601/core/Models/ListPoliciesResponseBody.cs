// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZ9FmxgN6wKfeK/GOKRnnjU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of access policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The description of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Read-only permission</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The content of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Action&quot;:[&quot;<em>:Describe</em>&quot;,&quot;<em>:List</em>&quot;,&quot;<em>:Get</em>&quot;,&quot;<em>:BatchGet</em>&quot;,&quot;<em>:Query</em>&quot;,&quot;<em>:BatchQuery</em>&quot;,&quot;actiontrail:LookupEvents&quot;],&quot;Resource&quot;:[&quot;*&quot;],&quot;Effect&quot;:&quot;Allow&quot;}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The name of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunComputeNestPolicyForReadOnly</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the access policy.</para>
            /// <list type="bullet">
            /// <item><description><para>Custom: A custom policy.</para>
            /// </description></item>
            /// <item><description><para>System: A system policy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
