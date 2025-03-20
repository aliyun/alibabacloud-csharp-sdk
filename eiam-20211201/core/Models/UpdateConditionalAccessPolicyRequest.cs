// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateConditionalAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Conditional Access Policy ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap_11111</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyId")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyId { get; set; }

        /// <summary>
        /// <para>Conditional Access Policy Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Policy</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyName")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyName { get; set; }

        /// <summary>
        /// <para>Conditional Access Policy Condition Content Configuration</para>
        /// </summary>
        [NameInMap("ConditionsConfig")]
        [Validation(Required=false)]
        public UpdateConditionalAccessPolicyRequestConditionsConfig ConditionsConfig { get; set; }
        public class UpdateConditionalAccessPolicyRequestConditionsConfig : TeaModel {
            /// <summary>
            /// <para>Target Applications for the Conditional Access Policy</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public UpdateConditionalAccessPolicyRequestConditionsConfigApplications Applications { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigApplications : TeaModel {
                /// <summary>
                /// <para>Excluded Applications</para>
                /// </summary>
                [NameInMap("ExcludeApplications")]
                [Validation(Required=false)]
                public List<string> ExcludeApplications { get; set; }

                /// <summary>
                /// <para>Included Applications</para>
                /// </summary>
                [NameInMap("IncludeApplications")]
                [Validation(Required=false)]
                public List<string> IncludeApplications { get; set; }

            }

            /// <summary>
            /// <para>Network zones for conditional access policy</para>
            /// </summary>
            [NameInMap("NetworkZones")]
            [Validation(Required=false)]
            public UpdateConditionalAccessPolicyRequestConditionsConfigNetworkZones NetworkZones { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigNetworkZones : TeaModel {
                /// <summary>
                /// <para>Excluded network zones</para>
                /// </summary>
                [NameInMap("ExcludeNetworkZones")]
                [Validation(Required=false)]
                public List<string> ExcludeNetworkZones { get; set; }

                /// <summary>
                /// <para>Included network zones</para>
                /// </summary>
                [NameInMap("IncludeNetworkZones")]
                [Validation(Required=false)]
                public List<string> IncludeNetworkZones { get; set; }

            }

            /// <summary>
            /// <para>Target Users for the Conditional Access Policy</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public UpdateConditionalAccessPolicyRequestConditionsConfigUsers Users { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigUsers : TeaModel {
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
                /// <para>Excluded Users</para>
                /// </summary>
                [NameInMap("ExcludeUsers")]
                [Validation(Required=false)]
                public List<string> ExcludeUsers { get; set; }

                /// <summary>
                /// <para>Included User Groups</para>
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
                /// <para>Included Users</para>
                /// </summary>
                [NameInMap("IncludeUsers")]
                [Validation(Required=false)]
                public List<string> IncludeUsers { get; set; }

            }

        }

        /// <summary>
        /// <para>Conditional Access Policy Action Configuration</para>
        /// </summary>
        [NameInMap("DecisionConfig")]
        [Validation(Required=false)]
        public UpdateConditionalAccessPolicyRequestDecisionConfig DecisionConfig { get; set; }
        public class UpdateConditionalAccessPolicyRequestDecisionConfig : TeaModel {
            /// <summary>
            /// <para>Whether to enable session reuse</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ActiveSessionReuseStatus")]
            [Validation(Required=false)]
            public string ActiveSessionReuseStatus { get; set; }

            /// <summary>
            /// <para>Conditional Access Policy Decision Action</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// <para>Conditional Access Policy Re-authentication Interval (seconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("MfaAuthenticationIntervalSeconds")]
            [Validation(Required=false)]
            public long? MfaAuthenticationIntervalSeconds { get; set; }

            /// <summary>
            /// <para>Allowed MFA types for the Conditional Access Policy</para>
            /// </summary>
            [NameInMap("MfaAuthenticationMethods")]
            [Validation(Required=false)]
            public List<string> MfaAuthenticationMethods { get; set; }

            /// <summary>
            /// <para>Conditional Access Policy MFA Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>directly_access</para>
            /// </summary>
            [NameInMap("MfaType")]
            [Validation(Required=false)]
            public string MfaType { get; set; }

        }

        /// <summary>
        /// <para>Conditional Access Policy Execution Type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enforcement</para>
        /// </summary>
        [NameInMap("DecisionType")]
        [Validation(Required=false)]
        public string DecisionType { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Priority of the conditional access policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
