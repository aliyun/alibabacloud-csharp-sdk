// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListConditionalAccessPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>Collection of conditional access policies</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicies")]
        [Validation(Required=false)]
        public List<ListConditionalAccessPoliciesResponseBodyConditionalAccessPolicies> ConditionalAccessPolicies { get; set; }
        public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPolicies : TeaModel {
            /// <summary>
            /// <para>Conditional access policy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp_xxxxx</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyId")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyId { get; set; }

            /// <summary>
            /// <para>Conditional access policy name</para>
            /// 
            /// <b>Example:</b>
            /// <para>My Policy</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyName")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyName { get; set; }

            /// <summary>
            /// <para>Type of the conditional access policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:policy:system</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyType")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyType { get; set; }

            /// <summary>
            /// <para>Content of the conditional access policy</para>
            /// </summary>
            [NameInMap("ConditionsConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfig ConditionsConfig { get; set; }
            public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfig : TeaModel {
                /// <summary>
                /// <para>Target applications of the conditional access policy</para>
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigApplications Applications { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigApplications : TeaModel {
                    /// <summary>
                    /// <para>Excluded applications</para>
                    /// </summary>
                    [NameInMap("ExcludeApplications")]
                    [Validation(Required=false)]
                    public List<string> ExcludeApplications { get; set; }

                    /// <summary>
                    /// <para>Selected applications</para>
                    /// </summary>
                    [NameInMap("IncludeApplications")]
                    [Validation(Required=false)]
                    public List<string> IncludeApplications { get; set; }

                }

                /// <summary>
                /// <para>Network zones for conditional access policies</para>
                /// </summary>
                [NameInMap("NetworkZones")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones NetworkZones { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones : TeaModel {
                    /// <summary>
                    /// <para>Excluded network zones</para>
                    /// </summary>
                    [NameInMap("ExcludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> ExcludeNetworkZones { get; set; }

                    /// <summary>
                    /// <para>Included network ranges</para>
                    /// </summary>
                    [NameInMap("IncludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> IncludeNetworkZones { get; set; }

                }

                /// <summary>
                /// <para>Target users of the conditional access policy</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigUsers Users { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigUsers : TeaModel {
                    /// <summary>
                    /// <para>Excluded user groups</para>
                    /// </summary>
                    [NameInMap("ExcludeGroups")]
                    [Validation(Required=false)]
                    public List<string> ExcludeGroups { get; set; }

                    /// <summary>
                    /// <para>Excluded organizations</para>
                    /// </summary>
                    [NameInMap("ExcludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> ExcludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>Excluded users</para>
                    /// </summary>
                    [NameInMap("ExcludeUsers")]
                    [Validation(Required=false)]
                    public List<string> ExcludeUsers { get; set; }

                    /// <summary>
                    /// <para>Included user groups</para>
                    /// </summary>
                    [NameInMap("IncludeGroups")]
                    [Validation(Required=false)]
                    public List<string> IncludeGroups { get; set; }

                    /// <summary>
                    /// <para>Included organizations</para>
                    /// </summary>
                    [NameInMap("IncludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> IncludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>Selected users</para>
                    /// </summary>
                    [NameInMap("IncludeUsers")]
                    [Validation(Required=false)]
                    public List<string> IncludeUsers { get; set; }

                }

            }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Action of the conditional access policy</para>
            /// </summary>
            [NameInMap("DecisionConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesDecisionConfig DecisionConfig { get; set; }
            public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesDecisionConfig : TeaModel {
                /// <summary>
                /// <para>Whether to enable session reuse for secondary authentication</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("ActiveSessionReuseStatus")]
                [Validation(Required=false)]
                public string ActiveSessionReuseStatus { get; set; }

                /// <summary>
                /// <para>Decision action of the conditional access policy:
                /// deny  Deny
                /// allow Allow</para>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>Re-authentication interval for the conditional access policy (in seconds) 300-86400</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MfaAuthenticationIntervalSeconds")]
                [Validation(Required=false)]
                public long? MfaAuthenticationIntervalSeconds { get; set; }

                /// <summary>
                /// <para>MFA types allowed by the conditional access policy</para>
                /// </summary>
                [NameInMap("MfaAuthenticationMethods")]
                [Validation(Required=false)]
                public List<string> MfaAuthenticationMethods { get; set; }

                /// <summary>
                /// <para>Conditional Access Policy Mfa Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>directly_access</para>
                /// </summary>
                [NameInMap("MfaType")]
                [Validation(Required=false)]
                public string MfaType { get; set; }

            }

            /// <summary>
            /// <para>Execution type of the conditional access policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>enforcement</para>
            /// </summary>
            [NameInMap("DecisionType")]
            [Validation(Required=false)]
            public string DecisionType { get; set; }

            /// <summary>
            /// <para>Description of the conditional access policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>My Policy Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Execution point of the conditional access policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:rule:eval_at:after_step1</para>
            /// </summary>
            [NameInMap("EvaluateAt")]
            [Validation(Required=false)]
            public string EvaluateAt { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ksvv5c7f2l6uzh6oqspeks23ni</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Last updated time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("LastUpdatedTime")]
            [Validation(Required=false)]
            public long? LastUpdatedTime { get; set; }

            /// <summary>
            /// <para>Priority, 1-100</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>Enable or disable status of the conditional access policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The token value returned by this call for the next page query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Previous page query token (Token)</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of items in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
