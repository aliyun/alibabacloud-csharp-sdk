// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateServiceEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the request. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The service endpoint information returned after the update is accepted. This includes the binding target, saved authentication and elasticity configurations, and current status. The endpoint may still be updating.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateServiceEndpointResponseBodyData Data { get; set; }
        public class UpdateServiceEndpointResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of access URLs for the service endpoint.</para>
            /// </summary>
            [NameInMap("accessUrls")]
            [Validation(Required=false)]
            public List<UpdateServiceEndpointResponseBodyDataAccessUrls> AccessUrls { get; set; }
            public class UpdateServiceEndpointResponseBodyDataAccessUrls : TeaModel {
                /// <summary>
                /// <para>The access URL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INTERNET</description></item>
                /// <item><description>VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INTERNET</para>
                /// </summary>
                [NameInMap("accessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The access URL status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING</description></item>
                /// <item><description>READY</description></item>
                /// <item><description>DEGRADED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>READY</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The reason for the access URL status. This parameter is returned with the specific cause when the status is abnormal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ServiceEndpoint.Provider.Unavailable: no provider for the target type</para>
                /// </summary>
                [NameInMap("statusReason")]
                [Validation(Required=false)]
                public string StatusReason { get; set; }

                /// <summary>
                /// <para>The access URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://endpoint.example.com">https://endpoint.example.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The authentication configuration of the service endpoint.</para>
            /// </summary>
            [NameInMap("authentication")]
            [Validation(Required=false)]
            public UpdateServiceEndpointResponseBodyDataAuthentication Authentication { get; set; }
            public class UpdateServiceEndpointResponseBodyDataAuthentication : TeaModel {
                /// <summary>
                /// <para>The authentication method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NONE: No authentication is required.</description></item>
                /// <item><description>API_KEY: Authentication is performed by passing the API key in the x-api-key request header.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>API_KEY</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The creation time in UTC format compliant with RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The read-only current number of instances. The Get operation queries RM sandboxPhaseCounts.RUNNING by endpoint runtimeKey. The Create and Update operations return null. The value is a non-negative integer, and null is returned when the statistics are unavailable. The value is not replaced by the base upper and lower limits, target quantity, or READY status. Unavailable statistics do not block submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("currentInstances")]
            [Validation(Required=false)]
            public int? CurrentInstances { get; set; }

            /// <summary>
            /// <para>The result of combining publicAccessEnabled with the workspace-level public inbound access limit. The value is true only when both settings allow public inbound access. This field only indicates the policy target and does not mean that the public endpoint has been fully provisioned. To determine the actual status, refer to accessUrls and status.</para>
            /// </summary>
            [NameInMap("effectivePublicAccessEnabled")]
            [Validation(Required=false)]
            public bool? EffectivePublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>The complete elasticity configuration saved for the service endpoint, which is used for edit backfill and is not the current effective upper and lower limits or the actual number of instances. The Get operation preferentially returns the saved configuration. If no configuration is saved, an endpoint that supports elasticity backfills the base values from the expected runtime frozen configuration or the bound version configuration when the runtime is not yet established, without requiring a successful publication. The value is null when the source is temporarily unavailable or no applicable configuration exists, but the status and statusReason are still returned. The Create and Update operations return only the saved configuration, and the value is null if no configuration is saved. The historical base capacity may exceed 100, and the read value is not truncated.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public UpdateServiceEndpointResponseBodyDataElasticityPolicy ElasticityPolicy { get; set; }
            public class UpdateServiceEndpointResponseBodyDataElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>The saved dynamic configuration. If the base configuration before the requirement goes online lacks the dynamicPolicy parameter, it is supplemented with enabled=false and policies=[].</para>
                /// </summary>
                [NameInMap("dynamicPolicy")]
                [Validation(Required=false)]
                public UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicy DynamicPolicy { get; set; }
                public class UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicy : TeaModel {
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
                    public List<UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicyPolicies> Policies { get; set; }
                    public class UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicyPolicies : TeaModel {
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
                        public List<UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicyPoliciesTimePoints> TimePoints { get; set; }
                        public class UpdateServiceEndpointResponseBodyDataElasticityPolicyDynamicPolicyPoliciesTimePoints : TeaModel {
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
                /// <para>The saved or backfilled base maximum number of instances, which is not less than minSandboxCount. The historical value may exceed 100, and the read value is not truncated. The base value is used when dynamic scaling is disabled or no candidates are available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>The saved or backfilled base minimum number of instances, which is a non-negative integer and not greater than maxSandboxCount. The historical value may exceed 100, and the read value is not truncated. A newly written complete configuration must still meet the 0 to 100 range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>The service endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT: The default endpoint created and maintained by the platform.</description></item>
            /// <item><description>NAMED: The named endpoint explicitly created by the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NAMED</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The service endpoint name. The name must be unique within the workspace and 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-endpoint</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The expected public inbound access setting configured on the service endpoint. For legacy service endpoints that have not been configured, true is returned. This field only indicates the configuration expectation. To determine the actual availability of the public endpoint, refer to accessUrls and status.</para>
            /// </summary>
            [NameInMap("publicAccessEnabled")]
            [Validation(Required=false)]
            public bool? PublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>The region ID of the service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The service endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-123456</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

            /// <summary>
            /// <para>The service endpoint status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING</description></item>
            /// <item><description>READY</description></item>
            /// <item><description>UPDATING</description></item>
            /// <item><description>DEGRADED</description></item>
            /// <item><description>DISABLED</description></item>
            /// <item><description>DELETING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the service endpoint status. This parameter is returned with the specific cause when the status is abnormal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceEndpoint.Provider.Unavailable: no provider for the target type</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The target routing configuration of the service endpoint.</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public UpdateServiceEndpointResponseBodyDataTarget Target { get; set; }
            public class UpdateServiceEndpointResponseBodyDataTarget : TeaModel {
                /// <summary>
                /// <para>The target agent ID. This parameter is returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-123456</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The target agent version. This parameter is returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("agentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// <para>The collaboration component type. This parameter is returned when the target type is TEAM_COLLABORATION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ELEMENT_WEB</para>
                /// </summary>
                [NameInMap("collaborationComponent")]
                [Validation(Required=false)]
                public string CollaborationComponent { get; set; }

                /// <summary>
                /// <para>The workspace resource binding ID associated with the target collaboration component. This parameter is returned when the target type is TEAM_COLLABORATION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wrb-123456</para>
                /// </summary>
                [NameInMap("resourceBindingId")]
                [Validation(Required=false)]
                public string ResourceBindingId { get; set; }

                /// <summary>
                /// <para>The target type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AGENT_VERSION</description></item>
                /// <item><description>TEAM_COLLABORATION</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT_VERSION</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The last update time in UTC format compliant with RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request. The value is 200 if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message of the request. The value is success if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E8F3C2A-1B4D-4F6E-9A7C-0D2B8E6F4A1C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates that the update request is accepted, but does not mean that the deployment or endpoint change is complete. You must check data.status and data.accessUrls to confirm the result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
