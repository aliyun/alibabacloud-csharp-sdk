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
            /// <para>The operation that is used for authentication in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram:DecodeDiagnosticMessage</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The conditions that are used for authentication in the request.</para>
            /// </summary>
            [NameInMap("AuthConditions")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions> AuthConditions { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions : TeaModel {
                /// <summary>
                /// <para>The key of the condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:SourceIp</para>
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// <para>The values that correspond to the key.</para>
                /// </summary>
                [NameInMap("ConditionValues")]
                [Validation(Required=false)]
                public List<string> ConditionValues { get; set; }

            }

            /// <summary>
            /// <para>The operator that is used for authentication in the request.</para>
            /// </summary>
            [NameInMap("AuthPrincipal")]
            [Validation(Required=false)]
            public DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal AuthPrincipal { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal : TeaModel {
                /// <summary>
                /// <para>The identity.</para>
                /// <list type="bullet">
                /// <item><description>If the operator is a RAM user, the ID of the user is displayed.</description></item>
                /// <item><description>If the operator is a RAM role, the name and session name of the role are displayed. Example: RoleName:RoleSessionName.</description></item>
                /// <item><description>If the operator is an SSO federated identity, the type and name of the identity provider (IdP) are displayed. Example: saml-provider/AzureAD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>28877424437521****</para>
                /// </summary>
                [NameInMap("AuthPrincipalDisplayName")]
                [Validation(Required=false)]
                public string AuthPrincipalDisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the identity belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196813200012****</para>
                /// </summary>
                [NameInMap("AuthPrincipalOwnerId")]
                [Validation(Required=false)]
                public string AuthPrincipalOwnerId { get; set; }

                /// <summary>
                /// <para>The identity type that is used for authentication in the request.</para>
                /// <para>Valid values:</para>
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

            }

            /// <summary>
            /// <para>The resource that is used for authentication in the request.</para>
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
            /// <para>Indicates whether the access denied error is caused by an explicit deny.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExplicitDeny")]
            [Validation(Required=false)]
            public bool? ExplicitDeny { get; set; }

            /// <summary>
            /// <para>The policies that are matched.</para>
            /// </summary>
            [NameInMap("MatchedPolicies")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies> MatchedPolicies { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies : TeaModel {
                /// <summary>
                /// <para>The type of the entity to which the policy is attached.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RamUser: RAM user</description></item>
                /// <item><description>RamRole: RAM role</description></item>
                /// <item><description>ResourceDirectoryTarget: entity in a resource directory</description></item>
                /// <item><description>RamGroup: RAM user group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RamUser</para>
                /// </summary>
                [NameInMap("AttachedEntityType")]
                [Validation(Required=false)]
                public string AttachedEntityType { get; set; }

                /// <summary>
                /// <para>The authorization scope of the policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Account: Alibaba Cloud account</description></item>
                /// <item><description>Folder: folder in the resource directory</description></item>
                /// <item><description>ResourceGroup: resource group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Account</para>
                /// </summary>
                [NameInMap("AttachedScope")]
                [Validation(Required=false)]
                public string AttachedScope { get; set; }

                /// <summary>
                /// <para>The effect of the policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Deny</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>Allow</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deny</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The identifier of the policy.</para>
                /// <list type="bullet">
                /// <item><description>Control policy: the ID of the control policy</description></item>
                /// <item><description>RAM policy: the name of the policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MyPolicyName</para>
                /// </summary>
                [NameInMap("PolicyIdentifier")]
                [Validation(Required=false)]
                public string PolicyIdentifier { get; set; }

                /// <summary>
                /// <para>The type of the policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom: custom policy</description></item>
                /// <item><description>System: system policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The version number of the policy.</para>
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
            /// <para>The type of the policy that causes the access denied error.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AssumeRolePolicy: role-specific trust policy</description></item>
            /// <item><description>ControlPolicy: control policy</description></item>
            /// <item><description>AccountLevelIdentityBasedPolicy: identity-based policy at the account level</description></item>
            /// <item><description>ResourceGroupLevelIdentityBasedPolicy: identity-based policy at the resource group level</description></item>
            /// <item><description>SessionPolicy: session policy</description></item>
            /// </list>
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
