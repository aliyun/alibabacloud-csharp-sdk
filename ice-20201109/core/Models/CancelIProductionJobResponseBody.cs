// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CancelIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public CancelIProductionJobResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class CancelIProductionJobResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ice:CancelIProductionJob</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity used for authentication in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RAM user: RAM user UID</description></item>
            /// <item><description>RAM role: RoleName:RoleSessionName</description></item>
            /// <item><description>Federated: ProviderType/ProviderName</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>4522705967</b></b></para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The account to which the authenticate principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>82303720</b></b></para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the identity used for authentication in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SubUser: RAM user</description></item>
            /// <item><description>AssumedRoleUser: RAM role</description></item>
            /// <item><description>Federated: SSO federated identity</description></item>
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
            /// <para>The type of denial by the access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ImplicitDeny</b>: The resource owner has not configured a relevant permission policy for the current user. Access to unauthorized operations is denied by default.</description></item>
            /// <item><description><b>ExplicitDeny</b>: The RAM policy configured by the resource owner explicitly denies the current user access to the corresponding resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of the policy that caused the access denial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ControlPolicy</b>: control policy.</description></item>
            /// <item><description><b>SessionPolicy</b>: an additional permission policy attached to a temporary token.</description></item>
            /// <item><description><b>AssumeRolePolicy</b>: the trust policy of a RAM role.</description></item>
            /// <item><description><b>AccountLevelIdentityBasedPolicy</b>: an identity-access policy at the account authorization scope, including custom policies and system policies.</description></item>
            /// <item><description><b>ResourceGroupLevelIdentityBasedPolicy</b>: an identity-access policy at the resource group authorization scope, including custom policies and system policies.</description></item>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
