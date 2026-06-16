// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateConditionalAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. The client generates the value of this parameter to ensure that the value is unique among different requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the conditional access policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap_11111</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyId")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the conditional access policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My conditional access policy</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyName")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyName { get; set; }

        /// <summary>
        /// <para>The condition configuration of the conditional access policy.</para>
        /// </summary>
        [NameInMap("ConditionsConfig")]
        [Validation(Required=false)]
        public UpdateConditionalAccessPolicyRequestConditionsConfig ConditionsConfig { get; set; }
        public class UpdateConditionalAccessPolicyRequestConditionsConfig : TeaModel {
            /// <summary>
            /// <para>The target applications of the conditional access policy.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public UpdateConditionalAccessPolicyRequestConditionsConfigApplications Applications { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigApplications : TeaModel {
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
            public UpdateConditionalAccessPolicyRequestConditionsConfigNetworkZones NetworkZones { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigNetworkZones : TeaModel {
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
            /// <para>The target users of the conditional access policy.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public UpdateConditionalAccessPolicyRequestConditionsConfigUsers Users { get; set; }
            public class UpdateConditionalAccessPolicyRequestConditionsConfigUsers : TeaModel {
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
        /// <para>The action configuration of the conditional access policy.</para>
        /// </summary>
        [NameInMap("DecisionConfig")]
        [Validation(Required=false)]
        public UpdateConditionalAccessPolicyRequestDecisionConfig DecisionConfig { get; set; }
        public class UpdateConditionalAccessPolicyRequestDecisionConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether to enable session reuse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ActiveSessionReuseStatus")]
            [Validation(Required=false)]
            public string ActiveSessionReuseStatus { get; set; }

            /// <summary>
            /// <para>The action of the conditional access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// <para>The interval at which the conditional access policy is repeatedly authenticated. Unit: seconds.</para>
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
        /// <para>The action that is performed by the conditional access policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reportOnly</para>
        /// </summary>
        [NameInMap("DecisionType")]
        [Validation(Required=false)]
        public string DecisionType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The priority of the conditional access policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
