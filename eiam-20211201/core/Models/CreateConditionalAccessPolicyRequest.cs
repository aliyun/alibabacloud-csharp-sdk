// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateConditionalAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Conditional access policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My conditional access policy</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyName")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyName { get; set; }

        /// <summary>
        /// <para>Conditional access policy type. Valid values:</para>
        /// <para>arn:alibaba:idaas:authn:access:policy:system: system policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:alibaba:idaas:authn:access:policy:system</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyType")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyType { get; set; }

        /// <summary>
        /// <para>Conditional access policy condition configuration.</para>
        /// </summary>
        [NameInMap("ConditionsConfig")]
        [Validation(Required=false)]
        public CreateConditionalAccessPolicyRequestConditionsConfig ConditionsConfig { get; set; }
        public class CreateConditionalAccessPolicyRequestConditionsConfig : TeaModel {
            /// <summary>
            /// <para>Conditional access policy target applications.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public CreateConditionalAccessPolicyRequestConditionsConfigApplications Applications { get; set; }
            public class CreateConditionalAccessPolicyRequestConditionsConfigApplications : TeaModel {
                /// <summary>
                /// <para>Excluded applications.</para>
                /// </summary>
                [NameInMap("ExcludeApplications")]
                [Validation(Required=false)]
                public List<string> ExcludeApplications { get; set; }

                /// <summary>
                /// <para>Included applications.</para>
                /// </summary>
                [NameInMap("IncludeApplications")]
                [Validation(Required=false)]
                public List<string> IncludeApplications { get; set; }

            }

            /// <summary>
            /// <para>Conditional access policy network zones.</para>
            /// </summary>
            [NameInMap("NetworkZones")]
            [Validation(Required=false)]
            public CreateConditionalAccessPolicyRequestConditionsConfigNetworkZones NetworkZones { get; set; }
            public class CreateConditionalAccessPolicyRequestConditionsConfigNetworkZones : TeaModel {
                /// <summary>
                /// <para>Excluded network zones.</para>
                /// </summary>
                [NameInMap("ExcludeNetworkZones")]
                [Validation(Required=false)]
                public List<string> ExcludeNetworkZones { get; set; }

                /// <summary>
                /// <para>Included network zones.</para>
                /// </summary>
                [NameInMap("IncludeNetworkZones")]
                [Validation(Required=false)]
                public List<string> IncludeNetworkZones { get; set; }

            }

            /// <summary>
            /// <para>Conditional access policy target users.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public CreateConditionalAccessPolicyRequestConditionsConfigUsers Users { get; set; }
            public class CreateConditionalAccessPolicyRequestConditionsConfigUsers : TeaModel {
                /// <summary>
                /// <para>Excluded user groups.</para>
                /// </summary>
                [NameInMap("ExcludeGroups")]
                [Validation(Required=false)]
                public List<string> ExcludeGroups { get; set; }

                /// <summary>
                /// <para>Excluded organizational units.</para>
                /// </summary>
                [NameInMap("ExcludeOrganizationalUnits")]
                [Validation(Required=false)]
                public List<string> ExcludeOrganizationalUnits { get; set; }

                /// <summary>
                /// <para>Excluded users.</para>
                /// </summary>
                [NameInMap("ExcludeUsers")]
                [Validation(Required=false)]
                public List<string> ExcludeUsers { get; set; }

                /// <summary>
                /// <para>Included user groups.</para>
                /// </summary>
                [NameInMap("IncludeGroups")]
                [Validation(Required=false)]
                public List<string> IncludeGroups { get; set; }

                /// <summary>
                /// <para>Included organizational units.</para>
                /// </summary>
                [NameInMap("IncludeOrganizationalUnits")]
                [Validation(Required=false)]
                public List<string> IncludeOrganizationalUnits { get; set; }

                /// <summary>
                /// <para>Included users.</para>
                /// </summary>
                [NameInMap("IncludeUsers")]
                [Validation(Required=false)]
                public List<string> IncludeUsers { get; set; }

            }

        }

        /// <summary>
        /// <para>Conditional access policy action configuration.</para>
        /// </summary>
        [NameInMap("DecisionConfig")]
        [Validation(Required=false)]
        public CreateConditionalAccessPolicyRequestDecisionConfig DecisionConfig { get; set; }
        public class CreateConditionalAccessPolicyRequestDecisionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable session reuse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ActiveSessionReuseStatus")]
            [Validation(Required=false)]
            public string ActiveSessionReuseStatus { get; set; }

            /// <summary>
            /// <para>Conditional access policy decision action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>allow: allow.</description></item>
            /// <item><description>deny: deny.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>allow or deny</para>
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// <para>Conditional access policy re-authentication interval (seconds).</para>
            /// <list type="bullet">
            /// <item><description>Maximum MFA authentication interval: 86400.</description></item>
            /// <item><description>Minimum MFA authentication interval: 300.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MfaAuthenticationIntervalSeconds")]
            [Validation(Required=false)]
            public long? MfaAuthenticationIntervalSeconds { get; set; }

            /// <summary>
            /// <para>MFA types allowed by the conditional access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ia_otp_sms: SMS verification code.</description></item>
            /// <item><description>ia_otp_email: email verification code.</description></item>
            /// <item><description>ia_totp: OTP dynamic password.</description></item>
            /// <item><description>ia_webauthn: WebAuthn.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("MfaAuthenticationMethods")]
            [Validation(Required=false)]
            public List<string> MfaAuthenticationMethods { get; set; }

            /// <summary>
            /// <para>Conditional access policy MFA type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>directly_access: direct access.</description></item>
            /// <item><description>mfa_required: MFA required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>directly_access</para>
            /// </summary>
            [NameInMap("MfaType")]
            [Validation(Required=false)]
            public string MfaType { get; set; }

        }

        /// <summary>
        /// <para>Conditional access policy execution type. Valid values:</para>
        /// <para>enforcement: enforcement policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enforcement</para>
        /// </summary>
        [NameInMap("DecisionType")]
        [Validation(Required=false)]
        public string DecisionType { get; set; }

        /// <summary>
        /// <para>Conditional access policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Conditional access policy evaluation point. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>arn:alibaba:idaas:authn:access:rule:eval_at:after_step1: allow.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:alibaba:idaas:authn:access:rule:eval_at:after_step1</para>
        /// </summary>
        [NameInMap("EvaluateAt")]
        [Validation(Required=false)]
        public string EvaluateAt { get; set; }

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
        /// <para>Conditional access policy priority. A smaller value indicates a higher priority.
        /// Minimum value: 1.
        /// Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
