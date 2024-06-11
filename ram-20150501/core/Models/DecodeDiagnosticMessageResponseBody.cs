// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageResponseBody : TeaModel {
        /// <summary>
        /// The decoded diagnostic information.
        /// </summary>
        [NameInMap("DecodedDiagnosticMessage")]
        [Validation(Required=false)]
        public DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessage DecodedDiagnosticMessage { get; set; }
        public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessage : TeaModel {
            /// <summary>
            /// The operation that is used for authentication in the request.
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// The conditions that are used for authentication in the request.
            /// </summary>
            [NameInMap("AuthConditions")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions> AuthConditions { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthConditions : TeaModel {
                /// <summary>
                /// The key of the condition.
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// The values that correspond to the key.
                /// </summary>
                [NameInMap("ConditionValues")]
                [Validation(Required=false)]
                public List<string> ConditionValues { get; set; }

            }

            /// <summary>
            /// The operator that is used for authentication in the request.
            /// </summary>
            [NameInMap("AuthPrincipal")]
            [Validation(Required=false)]
            public DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal AuthPrincipal { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageAuthPrincipal : TeaModel {
                /// <summary>
                /// The identity.
                /// 
                /// *   If the operator is a RAM user, the ID of the user is displayed.
                /// *   If the operator is a RAM role, the name and session name of the role are displayed. Example: RoleName:RoleSessionName.
                /// *   If the operator is an SSO federated identity, the type and name of the identity provider (IdP) are displayed. Example: saml-provider/AzureAD.
                /// </summary>
                [NameInMap("AuthPrincipalDisplayName")]
                [Validation(Required=false)]
                public string AuthPrincipalDisplayName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the identity belongs.
                /// </summary>
                [NameInMap("AuthPrincipalOwnerId")]
                [Validation(Required=false)]
                public string AuthPrincipalOwnerId { get; set; }

                /// <summary>
                /// The identity type that is used for authentication in the request.
                /// 
                /// Valid values:
                /// 
                /// *   SubUser: RAM user
                /// *   AssumedRoleUser: RAM role
                /// *   Federated: SSO federated identity
                /// </summary>
                [NameInMap("AuthPrincipalType")]
                [Validation(Required=false)]
                public string AuthPrincipalType { get; set; }

            }

            /// <summary>
            /// The resource that is used for authentication in the request.
            /// </summary>
            [NameInMap("AuthResource")]
            [Validation(Required=false)]
            public string AuthResource { get; set; }

            /// <summary>
            /// Indicates whether the access denied error is caused by an explicit deny.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ExplicitDeny")]
            [Validation(Required=false)]
            public bool? ExplicitDeny { get; set; }

            /// <summary>
            /// The policies that are matched.
            /// </summary>
            [NameInMap("MatchedPolicies")]
            [Validation(Required=false)]
            public List<DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies> MatchedPolicies { get; set; }
            public class DecodeDiagnosticMessageResponseBodyDecodedDiagnosticMessageMatchedPolicies : TeaModel {
                /// <summary>
                /// The type of the entity to which the policy is attached.
                /// 
                /// Valid values:
                /// 
                /// *   RamUser: RAM user
                /// *   RamRole: RAM role
                /// *   ResourceDirectoryTarget: entity in a resource directory
                /// *   RamGroup: RAM user group
                /// </summary>
                [NameInMap("AttachedEntityType")]
                [Validation(Required=false)]
                public string AttachedEntityType { get; set; }

                /// <summary>
                /// The authorization scope of the policy.
                /// 
                /// Valid values:
                /// 
                /// *   Account: Alibaba Cloud account
                /// *   Folder: folder in the resource directory
                /// *   ResourceGroup: resource group
                /// </summary>
                [NameInMap("AttachedScope")]
                [Validation(Required=false)]
                public string AttachedScope { get; set; }

                /// <summary>
                /// The effect of the policy.
                /// 
                /// Valid values:
                /// 
                /// *   Deny
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Allow
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The identifier of the policy.
                /// 
                /// *   Control policy: the ID of the control policy
                /// *   RAM policy: the name of the policy
                /// </summary>
                [NameInMap("PolicyIdentifier")]
                [Validation(Required=false)]
                public string PolicyIdentifier { get; set; }

                /// <summary>
                /// The type of the policy.
                /// 
                /// Valid values:
                /// *   Custom: custom policy
                /// *   System: system policy
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// The version number of the policy.
                /// 
                /// > Only custom policies have version numbers.
                /// </summary>
                [NameInMap("PolicyVersion")]
                [Validation(Required=false)]
                public string PolicyVersion { get; set; }

            }

            /// <summary>
            /// The type of the policy that causes the access denied error.
            /// 
            /// Valid values:
            /// 
            /// *   AssumeRolePolicy: role-specific trust policy
            /// *   ControlPolicy: control policy
            /// *   AccountLevelIdentityBasedPolicy: identity-based policy at the account level
            /// *   ResourceGroupLevelIdentityBasedPolicy: identity-based policy at the resource group level
            /// *   SessionPolicy: session policy
            /// </summary>
            [NameInMap("NoPermissionPolicyType")]
            [Validation(Required=false)]
            public string NoPermissionPolicyType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
