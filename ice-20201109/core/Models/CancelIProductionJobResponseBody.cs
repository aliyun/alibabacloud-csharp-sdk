// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CancelIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if Resource Access Management (RAM) permission verification failed.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public CancelIProductionJobResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class CancelIProductionJobResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The operation that failed the permission check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ice:CancelIProductionJob</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity. Values:</para>
            /// <list type="bullet">
            /// <item><description>RAM user: a UID</description></item>
            /// <item><description>RAM role: RoleName:RoleSessionName</description></item>
            /// <item><description>Federated user: ProviderType/ProviderName</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>4522705967</b></b></para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The account to which the principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>82303720</b></b></para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of identity that made the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SubUser: RAM user</description></item>
            /// <item><description>AssumedRoleUser: RAM role</description></item>
            /// <item><description>Federated: SSO federated user</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>AAZ/h8jzNEODc5QUUyLUZCOTAtNUQyQy1BMEFBLUUzODQxODUx</b></b></b>==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of policy that resulted in the denial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ImplicitDeny</b>: The resource holder has not configured a policy for the current user. By default, unauthorized operations are denied.</description></item>
            /// <item><description><b>ExplicitDeny</b>: The RAM policy configured by the resource holder explicitly denies the current user access to the corresponding resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of policy that triggered the permission failure.</para>
            /// <list type="bullet">
            /// <item><description><b>ControlPolicy</b>: control policy</description></item>
            /// <item><description><b>SessionPolicy</b>: an additional policy attached to a temporary token.</description></item>
            /// <item><description><b>AssumeRolePolicy</b>: the trust policy of a RAM role.</description></item>
            /// <item><description><b>AccountLevelIdentityBasedPolicy</b>: an identity-based policy at the account level (custom or system).</description></item>
            /// <item><description><b>ResourceGroupLevelIdentityBasedPolicy</b>: an identity-based policy scoped to a resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AssumeRolePolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
