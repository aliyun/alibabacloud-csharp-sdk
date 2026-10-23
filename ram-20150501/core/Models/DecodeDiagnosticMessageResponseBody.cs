// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The decoded diagnostic information.</para>
        /// </summary>
        [NameInMap("DecodedDiagnosticMessage")]
        [Validation(Required=false)]
        public DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessage DecodedDiagnosticMessage { get; set; }
        public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessage : TeaModel {
            /// <summary>
            /// <para>The action used for authentication in the user request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram:DecodeDiagnosticMessage</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The list of conditions used for authentication in the user request.</para>
            /// </summary>
            [NameInMap("AuthConditions")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions> AuthConditions { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions : TeaModel {
                /// <summary>
                /// <para>The condition key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:SourceIp</para>
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// <para>The list of values corresponding to the condition key.</para>
                /// </summary>
                [NameInMap("ConditionValues")]
                [Validation(Required=false)]
                public List<string> ConditionValues { get; set; }

            }

            /// <summary>
            /// <para>The principal used for authentication in the user request.</para>
            /// </summary>
            [NameInMap("AuthPrincipal")]
            [Validation(Required=false)]
            public DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal AuthPrincipal { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal : TeaModel {
                /// <summary>
                /// <para>The identity identifier used for authentication in the user request. The value varies based on the identity type:</para>
                /// <list type="bullet">
                /// <item><description>Resource Access Management (RAM) user: the UID of the RAM user.</description></item>
                /// <item><description>RAM role: the role name and role session name (example: RoleName:RoleSessionName).</description></item>
                /// <item><description>SSO federated identity: the identity provider type and identity provider name (example: saml-provider/AzureAD).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>28877424437521****</para>
                /// </summary>
                [NameInMap("AuthPrincipalDisplayName")]
                [Validation(Required=false)]
                public string AuthPrincipalDisplayName { get; set; }

                /// <summary>
                /// <para>The UID of the Alibaba Cloud account to which the identity used for authentication in the user request belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196813200012****</para>
                /// </summary>
                [NameInMap("AuthPrincipalOwnerId")]
                [Validation(Required=false)]
                public string AuthPrincipalOwnerId { get; set; }

                /// <summary>
                /// <para>The identity type used for authentication in the user request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SubUser</para>
                /// </summary>
                [NameInMap("AuthPrincipalType")]
                [Validation(Required=false)]
                public string AuthPrincipalType { get; set; }

            }

            /// <summary>
            /// <para>The resource used for authentication in the user request.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthResource")]
            [Validation(Required=false)]
            public string AuthResource { get; set; }

            /// <summary>
            /// <para>Indicates whether the request is explicitly denied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExplicitDeny")]
            [Validation(Required=false)]
            public bool? ExplicitDeny { get; set; }

            /// <summary>
            /// <para>The list of policies matched during authentication.</para>
            /// </summary>
            [NameInMap("MatchedPolicies")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies> MatchedPolicies { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies : TeaModel {
                /// <summary>
                /// <para>The type of the entity to which the policy is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RamUser</para>
                /// </summary>
                [NameInMap("AttachedEntityType")]
                [Validation(Required=false)]
                public string AttachedEntityType { get; set; }

                /// <summary>
                /// <para>The scope to which the policy is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Account</para>
                /// </summary>
                [NameInMap("AttachedScope")]
                [Validation(Required=false)]
                public string AttachedScope { get; set; }

                /// <summary>
                /// <para>The policy effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deny</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The policy name information. The value varies based on the policy type:</para>
                /// <list type="bullet">
                /// <item><description>Control policy: the ID of the control policy.</description></item>
                /// <item><description>RAM access policy: the name of the access policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MyPolicyName</para>
                /// </summary>
                [NameInMap("PolicyIdentifier")]
                [Validation(Required=false)]
                public string PolicyIdentifier { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The policy version number.</para>
                /// <remarks>
                /// <para>Only a custom policy has a version number.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("PolicyVersion")]
                [Validation(Required=false)]
                public string PolicyVersion { get; set; }

            }

            /// <summary>
            /// <para>The type of the policy that results in the access denied error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccountLevelIdentityBasedPolicy</para>
            /// </summary>
            [NameInMap("NoPermissionPolicyType")]
            [Validation(Required=false)]
            public string NoPermissionPolicyType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2331703-AADF-5564-BA9B-26CD51A33BA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
