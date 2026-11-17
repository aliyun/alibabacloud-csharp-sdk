// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateServiceEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The service endpoint configurations to be modified in this request. Submit the supported modifiable name, bound version, invocation authentication configuration, elastic policy, or public inbound access switch based on the endpoint type. Router and hybrid ingress endpoints cannot be renamed. DEFAULT endpoints do not accept name or authentication configuration updates. When updating the elastic policy, you must specify both updateElasticity=true and clientToken.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateServiceEndpointRequestBody Body { get; set; }
        public class UpdateServiceEndpointRequestBody : TeaModel {
            /// <summary>
            /// <para>If omitted, the original binding is retained. If specified, it must be an exact and successful source version of the agent. Otherwise, ServiceEndpointTargetNotReady is returned. When rebinding a DEFAULT service endpoint of the GATEWAY_API type, ServiceEndpointTargetNotReady is also returned if the original gateway runtime instance is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("agentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>Updates the invocation authentication configuration saved for the service endpoint, specified by type. If omitted, the original configuration is retained. This field is prohibited for DEFAULT endpoints. For AGENT_VERSION endpoints of non-EDGE agents, the actual API key verification is determined by the current inbound authentication configuration of the agent. The management API for updating the service endpoint still uses AccessKey or STS authentication and RAM authorization.</para>
            /// </summary>
            [NameInMap("authentication")]
            [Validation(Required=false)]
            public UpdateServiceEndpointRequestBodyAuthentication Authentication { get; set; }
            public class UpdateServiceEndpointRequestBodyAuthentication : TeaModel {
                /// <summary>
                /// <para>The saved invocation authentication type. Valid values: NONE: Configured not to use the endpoint API key. API_KEY: Configured to use the endpoint API key. For AGENT_VERSION endpoints of non-EDGE agents, the actual API key verification is determined by the current inbound authentication configuration of the agent and cannot be determined solely based on this field. You must provide type when passing authentication.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API_KEY</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Accepted only when updateElasticity is set to true. Omitting subfields retains the original values. The basic minSandboxCount and maxSandboxCount must be submitted in pairs. dynamicPolicy.enabled and policies can be updated separately. If policies is provided, it replaces the entire list. To clear the list, you must ensure that the final dynamicPolicy.enabled is set to false. elasticityPolicy and dynamicPolicy do not accept null, and an empty patch is invalid. Only Router endpoints and DEFAULT endpoints of the GATEWAY_API_WITH_VPC_INGRESS or GATEWAY_API_WITH_PUBLIC_INGRESS type support elasticity updates. The server merges, validates, and saves the complete configuration without backfilling basic values with the current capacity. The final basic min and max values must be between 0 and 100. If the historical basic capacity exceeds the limit, you must submit valid basic min and max values even if you only modify the dynamic policy. Silent truncation is not allowed.</para>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public UpdateServiceEndpointRequestBodyElasticityPolicy ElasticityPolicy { get; set; }
            public class UpdateServiceEndpointRequestBodyElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>The dynamic policy configuration. It must be fully provided during creation. If omitted during an update, the original configuration is retained. If provided, it is merged by field and does not accept null. The response returns the saved complete configuration. If no historical dynamic configuration exists, it is normalized to enabled=false and policies=[].</para>
                /// </summary>
                [NameInMap("dynamicPolicy")]
                [Validation(Required=false)]
                public UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicy DynamicPolicy { get; set; }
                public class UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicy : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the dynamic policy. This field is required during creation. If omitted during an update, the original value is retained. Disabling it retains existing policies and restores the basic upper and lower limits. Re-enabling it triggers immediate calculation. When finally enabled, policies cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The complete list of dynamic policies. This field is required during creation. If omitted during an update, the original list is retained. If provided, it replaces the entire list and is not merged by ID. To clear the list, you must ensure that the final enabled is set to false. Each item must be complete. Conditional requirements and cross-field constraints are validated by the server. The display order does not indicate priority.</para>
                    /// </summary>
                    [NameInMap("policies")]
                    [Validation(Required=false)]
                    public List<UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPolicies> Policies { get; set; }
                    public class UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPolicies : TeaModel {
                        /// <summary>
                        /// <para>The end time of the validity period. This field is required only when validity is set to range. The format is the same as startTime, and the seconds are fixed at 00. It must be later than startTime. The interval does not include the end time. If validity is set to forever, the start and end times must be omitted. Valid dates and cross-field constraints are validated by the console.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-12-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The policy identifier. This field is required and must be unique and stable within the endpoint. It is generated by the frontend when added, and retained during editing and retries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>policy-weekday</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The policy priority. This field is required. Valid values: 5: Regular. 10: High. New policies default to regular. You must explicitly provide this field upon submission, as the API does not set a default value. When the final dynamicPolicy.enabled is set to true, the validity periods of high-priority policies cannot overlap, except for end-to-end connections. Long-term high-priority policies can overlap with other high-priority policies. When disabled, overlapping drafts can be saved, and the final configuration is validated upon re-enabling. The validity of other fields and trigger conflicts within the policy are always validated. You must explicitly provide priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>The repeat cycle. This field is required. Valid values: daily: Every day. weekly: Every week. monthly: Every month. Only submit the fields corresponding to the cycle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>weekly</para>
                        /// </summary>
                        [NameInMap("repeat")]
                        [Validation(Required=false)]
                        public string Repeat { get; set; }

                        /// <summary>
                        /// <para>The start time of the validity period. This field is required only when validity is set to range. Format: YYYY-MM-DDTHH:mm:ss in the policy time zone, without a time zone offset. The seconds are fixed at 00. The interval includes the start time. Editing retains the existing past start time and does not reject updates or retries because it is earlier than the current time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-11-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The periodic trigger time points. This field is required and cannot be empty. Each item must be complete. The day of the week or day of the month is configured independently for each item. Within the same policy, daily policies conflict if the time is the same. weekly and monthly policies conflict only when the time is the same and the date sets intersect. This is validated by the console.</para>
                        /// </summary>
                        [NameInMap("timePoints")]
                        [Validation(Required=false)]
                        public List<UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPoliciesTimePoints> TimePoints { get; set; }
                        public class UpdateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPoliciesTimePoints : TeaModel {
                            /// <summary>
                            /// <para>The target maximum number of instances. This field is required. Valid values: 1 to 100.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("maxInstances")]
                            [Validation(Required=false)]
                            public int? MaxInstances { get; set; }

                            /// <summary>
                            /// <para>The target minimum number of instances. This field is required. Valid values: 0 to 100. The value cannot be greater than maxInstances in the same item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("minInstances")]
                            [Validation(Required=false)]
                            public int? MinInstances { get; set; }

                            /// <summary>
                            /// <para>The list of days in a month. This field is required for each trigger point of monthly policies. It cannot be empty and must be deduplicated. Valid values: integers from 1 to 31. Each row is selected independently. If a date does not exist in a month, the policy is not triggered and is not postponed to the end of the month. This field must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("monthDays")]
                            [Validation(Required=false)]
                            public List<int?> MonthDays { get; set; }

                            /// <summary>
                            /// <para>The trigger time. This field is required. Format: HH:mm:ss. It is interpreted in the time zone of the policy, accurate to the minute, and the seconds are fixed at 00.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>09:00:00</para>
                            /// </summary>
                            [NameInMap("time")]
                            [Validation(Required=false)]
                            public string Time { get; set; }

                            /// <summary>
                            /// <para>The list of weekdays. This field is required for each trigger point of weekly policies. It cannot be empty and must be deduplicated. Valid values: integers from 1 to 7. 1 indicates Monday, and 7 indicates Sunday. Each row is selected independently. This field must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("weekdays")]
                            [Validation(Required=false)]
                            public List<int?> Weekdays { get; set; }

                        }

                        /// <summary>
                        /// <para>The policy time zone. This field is required and must be a valid IANA time zone. All dates and times in this policy are interpreted in this time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Asia/Shanghai</para>
                        /// </summary>
                        [NameInMap("timeZone")]
                        [Validation(Required=false)]
                        public string TimeZone { get; set; }

                        /// <summary>
                        /// <para>The policy validity period type. This field is required. Valid values: forever: Long-term validity. range: Short-term validity. After expiration, the policy and its trigger results exit the current calculation, and the remaining policies are recalculated. If no candidates exist, the basic values are restored. The saved configuration is not automatically deleted.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>range</para>
                        /// </summary>
                        [NameInMap("validity")]
                        [Validation(Required=false)]
                        public string Validity { get; set; }

                    }

                }

                /// <summary>
                /// <para>Specifies whether to enable the global auto-elasticity mode. This field is independent of dynamicPolicy.enabled. If omitted during an update, the original value is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The saved basic maximum number of instances. Valid values: 0 to 100. The value cannot be less than minSandboxCount. The basic upper and lower limits are used when dynamic scaling is disabled or no candidates exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>The saved basic minimum number of instances. Valid values: 0 to 100. The value cannot be greater than maxSandboxCount. It must be submitted in pairs with maxSandboxCount during an update. Omitting both retains the original values. It does not override dynamic results when dynamic candidates exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>Used to modify existing named endpoints that support renaming. If omitted, the original name is retained. Router and hybrid ingress endpoints do not support renaming. You can only omit this field or pass the original name. This field is prohibited for DEFAULT endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable public inbound access for the service endpoint. If omitted, the original value is retained. If set to true or false, the value is replaced. Explicit null or non-boolean values return InvalidParameter and do not provide restore inheritance semantics. Modifying only this field triggers an ingress revision only and does not redeploy the runtime instance. Whether public network access is actually enabled is also subject to the public inbound access limit of the workspace. For more information, see effectivePublicAccessEnabled in the response.</para>
            /// </summary>
            [NameInMap("publicAccessEnabled")]
            [Validation(Required=false)]
            public bool? PublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to explicitly update the elasticity configuration in this request. If omitted or set to false, the elasticityPolicy carried in this request is ignored, and the saved configuration is retained. If set to true, a valid and non-empty elasticityPolicy patch and clientToken must be provided. This field is not persisted, returned, or passed through to the resource manager, and has no default value. Omit this field during regular editing and version rebinding.</para>
            /// </summary>
            [NameInMap("updateElasticity")]
            [Validation(Required=false)]
            public bool? UpdateElasticity { get; set; }

        }

        /// <summary>
        /// <para>The idempotent request token. This field is required when updateElasticity is set to true and is validated by the server. Reuse the token and the original request for the same retry. Use a new token if the logical content changes. Using the same token with different content returns InvalidParameter. The token must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), colons (:), and hyphens (-). The scope is the tenant and workspace. The receipt is retained for 7 days from the time of successful acceptance. Replays do not extend the retention period. After expiration, it is revalidated as a new submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
