// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetConditionalAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the conditional access policy.</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicy")]
        [Validation(Required=false)]
        public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicy ConditionalAccessPolicy { get; set; }
        public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicy : TeaModel {
            /// <summary>
            /// <para>The ID of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp_xxxxx</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyId")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My policy</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyName")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyName { get; set; }

            /// <summary>
            /// <para>The type of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:policy:system</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyType")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyType { get; set; }

            /// <summary>
            /// <para>The content of the conditional access policy.</para>
            /// </summary>
            [NameInMap("ConditionsConfig")]
            [Validation(Required=false)]
            public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfig ConditionsConfig { get; set; }
            public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfig : TeaModel {
                /// <summary>
                /// <para>The applications to which the conditional access policy applies.</para>
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigApplications Applications { get; set; }
                public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigApplications : TeaModel {
                    /// <summary>
                    /// <para>The excluded applications.</para>
                    /// </summary>
                    [NameInMap("ExcludeApplications")]
                    [Validation(Required=false)]
                    public List<string> ExcludeApplications { get; set; }

                    /// <summary>
                    /// <para>The selected applications.</para>
                    /// </summary>
                    [NameInMap("IncludeApplications")]
                    [Validation(Required=false)]
                    public List<string> IncludeApplications { get; set; }

                }

                /// <summary>
                /// <para>The network zones of the conditional access policy.</para>
                /// </summary>
                [NameInMap("NetworkZones")]
                [Validation(Required=false)]
                public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigNetworkZones NetworkZones { get; set; }
                public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigNetworkZones : TeaModel {
                    /// <summary>
                    /// <para>The excluded network zones.</para>
                    /// </summary>
                    [NameInMap("ExcludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> ExcludeNetworkZones { get; set; }

                    /// <summary>
                    /// <para>The selected network zones.</para>
                    /// </summary>
                    [NameInMap("IncludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> IncludeNetworkZones { get; set; }

                }

                /// <summary>
                /// <para>The users to whom the conditional access policy applies.</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigUsers Users { get; set; }
                public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyConditionsConfigUsers : TeaModel {
                    /// <summary>
                    /// <para>The excluded user groups.</para>
                    /// </summary>
                    [NameInMap("ExcludeGroups")]
                    [Validation(Required=false)]
                    public List<string> ExcludeGroups { get; set; }

                    /// <summary>
                    /// <para>The excluded organizations.</para>
                    /// </summary>
                    [NameInMap("ExcludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> ExcludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>The excluded users.</para>
                    /// </summary>
                    [NameInMap("ExcludeUsers")]
                    [Validation(Required=false)]
                    public List<string> ExcludeUsers { get; set; }

                    /// <summary>
                    /// <para>The selected user groups.</para>
                    /// </summary>
                    [NameInMap("IncludeGroups")]
                    [Validation(Required=false)]
                    public List<string> IncludeGroups { get; set; }

                    /// <summary>
                    /// <para>The selected organizations.</para>
                    /// </summary>
                    [NameInMap("IncludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> IncludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>The selected users.</para>
                    /// </summary>
                    [NameInMap("IncludeUsers")]
                    [Validation(Required=false)]
                    public List<string> IncludeUsers { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The action of the conditional access policy.</para>
            /// </summary>
            [NameInMap("DecisionConfig")]
            [Validation(Required=false)]
            public GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyDecisionConfig DecisionConfig { get; set; }
            public class GetConditionalAccessPolicyResponseBodyConditionalAccessPolicyDecisionConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether session reuse is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("ActiveSessionReuseStatus")]
                [Validation(Required=false)]
                public string ActiveSessionReuseStatus { get; set; }

                /// <summary>
                /// <para>The decision action of the conditional access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The interval in seconds at which re-authentication is required for the conditional access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MfaAuthenticationIntervalSeconds")]
                [Validation(Required=false)]
                public long? MfaAuthenticationIntervalSeconds { get; set; }

                /// <summary>
                /// <para>The MFA methods that are allowed by the conditional access policy.</para>
                /// </summary>
                [NameInMap("MfaAuthenticationMethods")]
                [Validation(Required=false)]
                public List<string> MfaAuthenticationMethods { get; set; }

                /// <summary>
                /// <para>The multi-factor authentication (MFA) type of the conditional access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>directly_access</para>
                /// </summary>
                [NameInMap("MfaType")]
                [Validation(Required=false)]
                public string MfaType { get; set; }

            }

            /// <summary>
            /// <para>The execution type of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enforcement</para>
            /// </summary>
            [NameInMap("DecisionType")]
            [Validation(Required=false)]
            public string DecisionType { get; set; }

            /// <summary>
            /// <para>The description of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga access port for ecs: internal-cn-hangzhou-docker-builder-2(i-bp19g1pheaailkk1xvr6)</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The policy enforcement point of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:rule:eval_at:after_step1</para>
            /// </summary>
            [NameInMap("EvaluateAt")]
            [Validation(Required=false)]
            public string EvaluateAt { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qnx6fbrinlecptl5hld23lfkvy</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the policy was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("LastUpdatedTime")]
            [Validation(Required=false)]
            public long? LastUpdatedTime { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The status of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
