// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListPermissionPoliciesInAccessConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The policies.</para>
        /// </summary>
        [NameInMap("PermissionPolicies")]
        [Validation(Required=false)]
        public List<ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies> PermissionPolicies { get; set; }
        public class ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies : TeaModel {
            /// <summary>
            /// <para>The time when the policy was created for the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-03T06:37:25Z</para>
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            /// <summary>
            /// <para>The configurations of the inline policy.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the PermissionPolicyType parameter is Inline.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Statement\&quot;: [{\&quot;Action\&quot;: \&quot;<em>\&quot;,\&quot;Effect\&quot;: \&quot;Allow\&quot;,\&quot;Resource\&quot;: \&quot;</em>\&quot;}],\&quot;Version\&quot;: \&quot;1\&quot;}</para>
            /// </summary>
            [NameInMap("PermissionPolicyDocument")]
            [Validation(Required=false)]
            public string PermissionPolicyDocument { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunECSFullAccess</para>
            /// </summary>
            [NameInMap("PermissionPolicyName")]
            [Validation(Required=false)]
            public string PermissionPolicyName { get; set; }

            /// <summary>
            /// <para>The type of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("PermissionPolicyType")]
            [Validation(Required=false)]
            public string PermissionPolicyType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A5E771F-1F5A-5555-A64E-579748AAFD98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
