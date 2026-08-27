// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The decoded diagnostic message.</para>
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
                /// <para>The key of the authentication condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:SourceIp</para>
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// <para>The list of values corresponding to the authentication condition key.</para>
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
                /// <para>The identity identifier used for authentication in the user request, as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>RAM user: The UID of the RAM user.</para>
                /// </description></item>
                /// <item><description><para>RAM role: The role name and role session name (for example, RoleName:RoleSessionName).</para>
                /// </description></item>
                /// <item><description><para>SSO federated identity: The identity provider type and name (for example, saml-provider/AzureAD).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>28877424437521****</para>
                /// </summary>
                [NameInMap("AuthPrincipalDisplayName")]
                [Validation(Required=false)]
                public string AuthPrincipalDisplayName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account UID of the identity used for authentication in the user request.</para>
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
            /// <para>Indicates whether the denial is explicit.</para>
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
                /// <para>The entity type to which the policy is attached.</para>
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
                /// <para>The policy name, as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>Control policy: The control policy ID.</para>
                /// </description></item>
                /// <item><description><para>RAM access policy: The access policy name.</para>
                /// </description></item>
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
                /// <para>Only custom policies have version numbers.</para>
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
            /// <para>The policy type that caused the permission denial.</para>
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
