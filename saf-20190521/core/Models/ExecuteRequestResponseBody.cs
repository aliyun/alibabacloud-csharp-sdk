// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Saf20190521.Models
{
    public class ExecuteRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic details for access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ExecuteRequestResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ExecuteRequestResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The specific action that the caller attempted to perform, such as s3:PutObject or ec2:DescribeInstances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundun-saf:Execute</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The human-readable display name of the request principal, such as the username or role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29918048924096****</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account to which the request principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>178059440630****</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type of the request principal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SubUser: RAM user created by an Alibaba Cloud account.</description></item>
            /// <item><description>AssumedRoleUser: Temporary identity obtained by assuming a role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The Base64-encoded permission diagnostic log used for troubleshooting and automated analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQIBIAAAA...r+ow==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The specific denial type for the access denied scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ImplicitDeny: Implicit deny due to the lack of explicit authorization.</description></item>
            /// <item><description>ExplicitDeny: Explicit deny where the operation is explicitly denied in the policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The scope and type of the policy in the access denied scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AccountLevelIdentityBasedPolicy: Account-level identity-based policy that applies to the entire Alibaba Cloud account.</description></item>
            /// <item><description>ResourceGroupLevelIdentityBasedPolicy: Resource group-level identity-based policy that applies to a specific resource group.</description></item>
            /// <item><description>SessionPolicy: Session policy that applies to a temporary session.</description></item>
            /// <item><description>ControlPolicy: Control policy used for core permission control.</description></item>
            /// <item><description>AssumeRolePolicy: Trust policy that defines which entities can assume the role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AccountLevelIdentityBasedPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data, which includes fields such as tags, score, and extend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;score&quot;: 80.4, &quot;tags&quot;: &quot;ra0601,rnk0002,rn0312&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F41DC6-2070-5CE7-8B2D-7A23D882932D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
