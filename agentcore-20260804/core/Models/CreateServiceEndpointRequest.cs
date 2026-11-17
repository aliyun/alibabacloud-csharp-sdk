// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateServiceEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The name, routing target, and invocation authentication configuration of the service endpoint to be created, as well as the optional initial elasticity configuration and public network inbound switch.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateServiceEndpointRequestBody Body { get; set; }
        public class CreateServiceEndpointRequestBody : TeaModel {
            /// <summary>
            /// <para>Sets the invocation authentication configuration saved for the service endpoint, specified by type. For AGENT_VERSION endpoints of non-EDGE agents, the actual API key verification is determined by the current inbound authentication configuration of the agent. The management operation for creating service endpoints still uses AccessKey (AK) or Security Token Service (STS) authentication and Resource Access Management (RAM) authorization.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("authentication")]
            [Validation(Required=false)]
            public CreateServiceEndpointRequestBodyAuthentication Authentication { get; set; }
            public class CreateServiceEndpointRequestBodyAuthentication : TeaModel {
                /// <summary>
                /// <para>The saved invocation authentication type. NONE indicates that the endpoint API key is not used. API_KEY indicates that the endpoint API key is used. For AGENT_VERSION endpoints of non-EDGE agents, the actual API key verification is determined by the current inbound authentication configuration of the agent and cannot be determined solely based on this field.</para>
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
            /// <para>Explicitly provided when creating a service endpoint with elasticity capabilities. The capability scope follows existing rules. Null or partial patches are not accepted. It must include enabled, the basic minSandboxCount and maxSandboxCount, and the complete dynamicPolicy. The basic upper and lower limits are both 0 to 100, and min must be less than or equal to max. To disable dynamic scaling without policies, pass enabled=false and policies=[]. A clientToken must be included when elasticity initialization is involved, and updateElasticity must not be passed. Conditional requirements and cross-field constraints are verified by the server.</para>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public CreateServiceEndpointRequestBodyElasticityPolicy ElasticityPolicy { get; set; }
            public class CreateServiceEndpointRequestBodyElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>Required. Must include enabled and policies. Verified by the server. Independent of the overall auto-elasticity switch.</para>
                /// </summary>
                [NameInMap("dynamicPolicy")]
                [Validation(Required=false)]
                public CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicy DynamicPolicy { get; set; }
                public class CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicy : TeaModel {
                    /// <summary>
                    /// <para>Required during creation. If omitted during an update, the original value is retained. Disabling it retains existing policies and restores the basic upper and lower limits. Re-enabling it triggers immediate calculation. When finally enabled, policies must not be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>Required during creation. If omitted during an update, the original list is retained. If passed, the entire list is replaced and not merged by ID. To clear the list, you must also ensure that the final enabled value is false. Each item must be complete. Conditional requirements and cross-field constraints are verified by the server. The display order does not indicate priority.</para>
                    /// </summary>
                    [NameInMap("policies")]
                    [Validation(Required=false)]
                    public List<CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPolicies> Policies { get; set; }
                    public class CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPolicies : TeaModel {
                        /// <summary>
                        /// <para>Required only when validity is set to range. The format is the same as startTime, the seconds are fixed at 00, and it must be later than startTime. The interval does not include the end time. Start and end times must be omitted for forever. Valid dates and cross-field constraints are verified by the console.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-12-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>Required. Must be unique and stable within the endpoint. Generated by the frontend when added, and retained during editing and retries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>policy-weekday</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Required. 5 indicates regular, and 10 indicates high priority. New policies default to regular. Must be explicitly included when submitted, and no default value is set for the operation. When the final dynamicPolicy.enabled is true, the validity periods of high-priority policies must not overlap, except for end-to-end connections. Long-term high-priority policies can overlap with other high-priority policies. When disabled, overlapping drafts can be saved, and the final configuration is verified when re-enabled. The validity of other fields and trigger conflicts within the policy are always verified. priority must be explicitly provided.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>Required. daily indicates every day, weekly indicates every week, and monthly indicates every month. Only submit fields corresponding to the cycle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>weekly</para>
                        /// </summary>
                        [NameInMap("repeat")]
                        [Validation(Required=false)]
                        public string Repeat { get; set; }

                        /// <summary>
                        /// <para>Required only when validity is set to range. Format: YYYY-MM-DDTHH:mm:ss in the policy time zone, without time zone offset, and the seconds are fixed at 00. The interval includes the start time. Editing retains the existing past start time and does not reject updates or retries because it is earlier than the current time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-11-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>Required and non-empty. Each item must be complete. The day of the week or day of the month is configured independently for each item. Within the same policy, daily policies conflict if the time is the same. weekly and monthly policies conflict only if the time is the same and the date sets intersect. Verified by the console.</para>
                        /// </summary>
                        [NameInMap("timePoints")]
                        [Validation(Required=false)]
                        public List<CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPoliciesTimePoints> TimePoints { get; set; }
                        public class CreateServiceEndpointRequestBodyElasticityPolicyDynamicPolicyPoliciesTimePoints : TeaModel {
                            /// <summary>
                            /// <para>Required. 1 to 100.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("maxInstances")]
                            [Validation(Required=false)]
                            public int? MaxInstances { get; set; }

                            /// <summary>
                            /// <para>Required. 0 to 100, and not greater than maxInstances of the same item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("minInstances")]
                            [Validation(Required=false)]
                            public int? MinInstances { get; set; }

                            /// <summary>
                            /// <para>Required only for each trigger point of monthly. Must be non-empty and deduplicated. Integers from 1 to 31. Selected independently for each row. Dates that do not exist in the month do not trigger and are not postponed to the end of the month. Must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("monthDays")]
                            [Validation(Required=false)]
                            public List<int?> MonthDays { get; set; }

                            /// <summary>
                            /// <para>Required. Format: HH:mm:ss. Interpreted in the time zone of the policy, accurate to the minute, and the seconds are fixed at 00.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>09:00:00</para>
                            /// </summary>
                            [NameInMap("time")]
                            [Validation(Required=false)]
                            public string Time { get; set; }

                            /// <summary>
                            /// <para>Required only for each trigger point of weekly. Must be non-empty and deduplicated. Integers from 1 to 7, where 1 indicates Monday and 7 indicates Sunday. Selected independently for each row. Must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("weekdays")]
                            [Validation(Required=false)]
                            public List<int?> Weekdays { get; set; }

                        }

                        /// <summary>
                        /// <para>Required. A valid IANA time zone. All dates and times in this policy are interpreted in this time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Asia/Shanghai</para>
                        /// </summary>
                        [NameInMap("timeZone")]
                        [Validation(Required=false)]
                        public string TimeZone { get; set; }

                        /// <summary>
                        /// <para>Required. forever indicates long-term validity, and range indicates short-term validity. After expiration, the policy and its trigger results exit the current calculation, and the remaining policies are recalculated. If there are no candidates, the basic values are restored, and the saved configurations are not automatically deleted.</para>
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
                /// <para>Must be provided when elasticityPolicy is passed. Verified by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Must be provided when elasticityPolicy is passed. Verified by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>Must be provided when elasticityPolicy is passed. Verified by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>The name of the named service endpoint to be created. For the Router type, the name must be 1 to 128 characters in length and can contain lowercase letters, digits, underscores (_), and hyphens (-). It must start with a letter or a digit, cannot use the reserved name default, and must be unique within the same agent. The names of Router and hybrid ingress endpoints cannot be changed after creation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Initialized to true when omitted. Saved as the passed value when true or false is passed. Returns InvalidParameter for explicit null or non-boolean values. Whether the public network is actually enabled is also subject to the public network inbound limit of the workspace. See effectivePublicAccessEnabled in the response.</para>
            /// </summary>
            [NameInMap("publicAccessEnabled")]
            [Validation(Required=false)]
            public bool? PublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>Specifies the agent and its version associated with the service endpoint. The routing targets of collaboration components are maintained internally by the platform.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public CreateServiceEndpointRequestBodyTarget Target { get; set; }
            public class CreateServiceEndpointRequestBodyTarget : TeaModel {
                /// <summary>
                /// <para>The ID of the agent associated with the AGENT_VERSION routing target. The agent is located in the workspace specified in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-0123456789abcdef0123456789abcdef</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The version number of the agent associated with the AGENT_VERSION routing target. Use the agentVersion returned by CreateAgentVersion or ListAgentVersions, which is different from the version name versionName.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("agentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// <para>The component associated with the TEAM_COLLABORATION routing target. MATRIX_CLIENT indicates the Matrix client ingress, MATRIX_FEDERATION indicates the Matrix federation ingress, and ELEMENT_WEB indicates the Element Web ingress. Service endpoints for collaboration components are created internally by the platform. Do not pass this field when publicly creating an AGENT_VERSION endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MATRIX_CLIENT</para>
                /// </summary>
                [NameInMap("collaborationComponent")]
                [Validation(Required=false)]
                public string CollaborationComponent { get; set; }

                /// <summary>
                /// <para>The ID of the resource binding associated with the TEAM_COLLABORATION routing target. It is maintained internally by the platform and generated in the format of wrb- followed by a 32-character hexadecimal UUID. Do not pass this field when publicly creating an AGENT_VERSION endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wrb-0123456789abcdef0123456789abcdef</para>
                /// </summary>
                [NameInMap("resourceBindingId")]
                [Validation(Required=false)]
                public string ResourceBindingId { get; set; }

                /// <summary>
                /// <para>The public creation operation only supports AGENT_VERSION, which indicates routing to a specified agent version. TEAM_COLLABORATION indicates a collaboration component. Service endpoints for collaboration components are created internally by the platform.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT_VERSION</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>Required when elasticity initialization is involved. Verified by the server. Reuse the token and the original request for the same retry. Use a new token if the logical content changes. Returns InvalidParameter for the same token with different content. The token must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), colons (:), and hyphens (-). The scope is the tenant and workspace. The receipt is retained for 7 days from the time of successful acceptance. Replays do not extend the retention period. After expiration, it is re-verified as a new submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
