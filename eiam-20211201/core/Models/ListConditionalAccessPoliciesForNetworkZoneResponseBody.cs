// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListConditionalAccessPoliciesForNetworkZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of conditional access policies.</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicies")]
        [Validation(Required=false)]
        public List<ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPolicies> ConditionalAccessPolicies { get; set; }
        public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPolicies : TeaModel {
            /// <summary>
            /// <para>The conditional access policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp_xxxxx</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyId")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyId { get; set; }

            /// <summary>
            /// <para>The conditional access policy name.</para>
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
            /// <para>The conditions configuration of the conditional access policy.</para>
            /// </summary>
            [NameInMap("ConditionsConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfig ConditionsConfig { get; set; }
            public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfig : TeaModel {
                /// <summary>
                /// <para>The target applications of the conditional access policy.</para>
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigApplications Applications { get; set; }
                public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigApplications : TeaModel {
                    /// <summary>
                    /// <para>The excluded applications.</para>
                    /// </summary>
                    [NameInMap("ExcludeApplications")]
                    [Validation(Required=false)]
                    public List<string> ExcludeApplications { get; set; }

                    /// <summary>
                    /// <para>The included applications.</para>
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
                public ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones NetworkZones { get; set; }
                public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones : TeaModel {
                    /// <summary>
                    /// <para>The excluded network zones.</para>
                    /// </summary>
                    [NameInMap("ExcludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> ExcludeNetworkZones { get; set; }

                    /// <summary>
                    /// <para>The included network zones.</para>
                    /// </summary>
                    [NameInMap("IncludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> IncludeNetworkZones { get; set; }

                }

                /// <summary>
                /// <para>The target users of the conditional access policy.</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigUsers Users { get; set; }
                public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesConditionsConfigUsers : TeaModel {
                    /// <summary>
                    /// <para>The excluded user groups.</para>
                    /// </summary>
                    [NameInMap("ExcludeGroups")]
                    [Validation(Required=false)]
                    public List<string> ExcludeGroups { get; set; }

                    /// <summary>
                    /// <para>The excluded organizational units.</para>
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
                    /// <para>The included user groups.</para>
                    /// </summary>
                    [NameInMap("IncludeGroups")]
                    [Validation(Required=false)]
                    public List<string> IncludeGroups { get; set; }

                    /// <summary>
                    /// <para>The included organizational units.</para>
                    /// </summary>
                    [NameInMap("IncludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> IncludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>The included users.</para>
                    /// </summary>
                    [NameInMap("IncludeUsers")]
                    [Validation(Required=false)]
                    public List<string> IncludeUsers { get; set; }

                }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The decision action configuration of the conditional access policy.</para>
            /// </summary>
            [NameInMap("DecisionConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesDecisionConfig DecisionConfig { get; set; }
            public class ListConditionalAccessPoliciesForNetworkZoneResponseBodyConditionalAccessPoliciesDecisionConfig : TeaModel {
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
                /// <para>The re-authentication interval of the conditional access policy, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MfaAuthenticationIntervalSeconds")]
                [Validation(Required=false)]
                public long? MfaAuthenticationIntervalSeconds { get; set; }

                /// <summary>
                /// <para>The MFA methods allowed by the conditional access policy.</para>
                /// </summary>
                [NameInMap("MfaAuthenticationMethods")]
                [Validation(Required=false)]
                public List<string> MfaAuthenticationMethods { get; set; }

                /// <summary>
                /// <para>The MFA type of the conditional access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>directly_access</para>
                /// </summary>
                [NameInMap("MfaType")]
                [Validation(Required=false)]
                public string MfaType { get; set; }

            }

            /// <summary>
            /// <para>The decision type of the conditional access policy.</para>
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
            /// <para>terraform-example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The evaluation point of the conditional access policy.</para>
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
            /// <para>idaas_oynbcyaaejuik6b37eldz4pinu</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The last updated time.</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The enabled or disabled status of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
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
