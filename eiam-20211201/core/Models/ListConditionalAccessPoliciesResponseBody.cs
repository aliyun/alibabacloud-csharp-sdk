// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListConditionalAccessPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of conditional access policies.</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicies")]
        [Validation(Required=false)]
        public List<ListConditionalAccessPoliciesResponseBodyConditionalAccessPolicies> ConditionalAccessPolicies { get; set; }
        public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPolicies : TeaModel {
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
            /// <para>The Policy Name of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyPolicy</para>
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
            public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfig ConditionsConfig { get; set; }
            public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfig : TeaModel {
                /// <summary>
                /// <para>The target applications of the conditional access policy.</para>
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigApplications Applications { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigApplications : TeaModel {
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
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones NetworkZones { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones : TeaModel {
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
                public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigUsers Users { get; set; }
                public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesConditionsConfigUsers : TeaModel {
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
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
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
            public ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesDecisionConfig DecisionConfig { get; set; }
            public class ListConditionalAccessPoliciesResponseBodyConditionalAccessPoliciesDecisionConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether secondary authentication session reuse is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("ActiveSessionReuseStatus")]
                [Validation(Required=false)]
                public string ActiveSessionReuseStatus { get; set; }

                /// <summary>
                /// <para>The decision action of the conditional access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>deny: Deny.</description></item>
                /// <item><description>allow: Allow.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The MFA re-authentication interval of the conditional access policy, in seconds. Valid values: 300 to 86400.</para>
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
            /// <para>My policy description</para>
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
            /// <para>idaas_ksvv5c7f2l6uzh6oqspeks23ni</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The update time. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("LastUpdatedTime")]
            [Validation(Required=false)]
            public long? LastUpdatedTime { get; set; }

            /// <summary>
            /// <para>The priority. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>The query token (Token) value returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination token for the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
