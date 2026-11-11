// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListServiceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of service endpoints.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListServiceEndpointsResponseBodyItems> Items { get; set; }
        public class ListServiceEndpointsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of access URLs for the service endpoint.</para>
            /// </summary>
            [NameInMap("accessUrls")]
            [Validation(Required=false)]
            public List<ListServiceEndpointsResponseBodyItemsAccessUrls> AccessUrls { get; set; }
            public class ListServiceEndpointsResponseBodyItemsAccessUrls : TeaModel {
                /// <summary>
                /// <para>The type of the access URL. Valid values: INTERNET and VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INTERNET</para>
                /// </summary>
                [NameInMap("accessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The status of the access URL. Valid values: CREATING, READY, and DEGRADED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>READY</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The reason for the access URL status. Returns the specific reason when the status is abnormal.</para>
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
            public ListServiceEndpointsResponseBodyItemsAuthentication Authentication { get; set; }
            public class ListServiceEndpointsResponseBodyItemsAuthentication : TeaModel {
                /// <summary>
                /// <para>The authentication method. NONE indicates that no authentication is required. API_KEY indicates that authentication is performed by passing an API key in the x-api-key request header.</para>
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
            /// <para>Read-only. This is a shared response field. The list operation does not query RM row by row and returns null. For details, call the GetServiceEndpoint operation to query sandboxPhaseCounts.RUNNING based on the endpoint runtimeKey. Do not replace it with the baseline upper and lower limits, target quantity, or READY status.</para>
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
            /// <para>The result of combining publicAccessEnabled with the public inbound access upper limit of the workspace. The value is true only when both allow public inbound access. This only indicates the policy target and does not mean that the public endpoint has been published. The actual status is subject to accessUrls and status.</para>
            /// </summary>
            [NameInMap("effectivePublicAccessEnabled")]
            [Validation(Required=false)]
            public bool? EffectivePublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>Includes the enabled status, basic minSandboxCount and maxSandboxCount, and dynamicPolicy. This does not represent the currently effective limits or the actual number of instances. If the basic configuration lacks dynamicPolicy before the feature is released, it is supplemented with enabled=false and policies=[]. This parameter is null if the endpoint configuration is not saved, and the list does not backfill the version source. Historical basic capacity can exceed 100. Retrieve the details again when you open the edit page.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public ListServiceEndpointsResponseBodyItemsElasticityPolicy ElasticityPolicy { get; set; }
            public class ListServiceEndpointsResponseBodyItemsElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>Returns the saved dynamic configuration. If the basic configuration lacks dynamicPolicy before the feature is released, it is supplemented with enabled=false and policies=[].</para>
                /// </summary>
                [NameInMap("dynamicPolicy")]
                [Validation(Required=false)]
                public ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicy DynamicPolicy { get; set; }
                public class ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicy : TeaModel {
                    /// <summary>
                    /// <para>Required during creation. If omitted during an update, the original value is retained. Disabling it retains existing policies and restores the basic upper and lower limits. Enabling it again triggers immediate calculation. When finally enabled, policies must not be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>Required during creation. If omitted during an update, the original list is retained. If provided, it replaces the entire list and is not merged by ID. To clear the list, you must also ensure that the final enabled status is false. Each item must be complete. Conditional requirements and cross-field constraints are validated by the server. The display order does not indicate priority.</para>
                    /// </summary>
                    [NameInMap("policies")]
                    [Validation(Required=false)]
                    public List<ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicyPolicies> Policies { get; set; }
                    public class ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicyPolicies : TeaModel {
                        /// <summary>
                        /// <para>Required only when validity is set to range. The format is the same as startTime, and the seconds are fixed at 00. The value must be later than startTime. The interval does not include the end time. If validity is set to forever, the start and end times must be omitted. Valid dates and cross-field constraints are verified by the console.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-12-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>Required. It must be unique and stable within the endpoint. It is generated by the frontend when added, and retained during editing and retries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>policy-weekday</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Required. Valid values: 5 for regular and 10 for high priority. New policies default to regular priority. It must be explicitly provided during submission, and no default value is set by the API. When dynamicPolicy.enabled is finally true, the validity periods of high-priority policies must not overlap, except for end-to-end connections. Long-term high-priority policies can overlap with other high-priority policies. Overlapping drafts can be saved when disabled, and the final configuration is validated when re-enabled. The validity of other fields and trigger conflicts within the policy are always validated. The priority must be explicitly provided.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>Required. Valid values: daily for every day, weekly for every week, and monthly for every month. Only submit the fields corresponding to the specified cycle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>weekly</para>
                        /// </summary>
                        [NameInMap("repeat")]
                        [Validation(Required=false)]
                        public string Repeat { get; set; }

                        /// <summary>
                        /// <para>Required only when validity is set to range. The format is YYYY-MM-DDTHH:mm:ss in the time zone of the policy, without a time zone offset. The seconds are fixed at 00. The interval includes the start time. When editing, the existing past start time is retained, and updates or retries are not rejected even if it is earlier than the current time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-11-01T00:00:00</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>Required and non-empty. Each item must be complete. The day of the week or day of the month is configured independently for each item. Within the same policy, daily policies conflict if they have the same time. Weekly and monthly policies conflict only if they have the same time and their date sets intersect. This is validated by the console.</para>
                        /// </summary>
                        [NameInMap("timePoints")]
                        [Validation(Required=false)]
                        public List<ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicyPoliciesTimePoints> TimePoints { get; set; }
                        public class ListServiceEndpointsResponseBodyItemsElasticityPolicyDynamicPolicyPoliciesTimePoints : TeaModel {
                            /// <summary>
                            /// <para>Required. The value ranges from 1 to 100.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("maxInstances")]
                            [Validation(Required=false)]
                            public int? MaxInstances { get; set; }

                            /// <summary>
                            /// <para>Required. The value ranges from 0 to 100 and must not be greater than the maxInstances value in the same item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("minInstances")]
                            [Validation(Required=false)]
                            public int? MinInstances { get; set; }

                            /// <summary>
                            /// <para>Required only for each trigger point of the monthly cycle. Must be non-empty and contain unique integers from 1 to 31. Each row is selected independently. If a date does not exist in a specific month, the trigger does not occur and is not postponed to the end of the month. Must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("monthDays")]
                            [Validation(Required=false)]
                            public List<int?> MonthDays { get; set; }

                            /// <summary>
                            /// <para>Required. The format is HH:mm:ss. The time is interpreted based on the time zone of the associated policy. The precision is down to the minute, and the seconds are fixed at 00.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>09:00:00</para>
                            /// </summary>
                            [NameInMap("time")]
                            [Validation(Required=false)]
                            public string Time { get; set; }

                            /// <summary>
                            /// <para>Required only for each trigger point of weekly policies. It must be non-empty and deduplicated. Valid values are integers from 1 to 7, where 1 represents Monday and 7 represents Sunday. Each row is selected independently. It must be omitted for other cycles.</para>
                            /// </summary>
                            [NameInMap("weekdays")]
                            [Validation(Required=false)]
                            public List<int?> Weekdays { get; set; }

                        }

                        /// <summary>
                        /// <para>Required. It must be a valid IANA time zone. All dates and times in this policy are interpreted in this time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Asia/Shanghai</para>
                        /// </summary>
                        [NameInMap("timeZone")]
                        [Validation(Required=false)]
                        public string TimeZone { get; set; }

                        /// <summary>
                        /// <para>Required. Valid values: forever: The policy is permanently valid. range: The policy is valid for a specific period. After expiration, the policy and its trigger results exit the current calculation, and the remaining policies are recalculated. If no candidates are available, the baseline values are restored, and the saved configurations are not automatically deleted.</para>
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
                /// <para>Independent of dynamicPolicy.enabled. If omitted during an update, the original value is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The saved or backfilled basic maximum number of instances. It must not be less than minSandboxCount. Historical values can exceed 100 and are not truncated when read. The basic value is used when dynamic scaling is disabled or no candidates are available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>The saved or backfilled basic minimum number of instances. It must be a non-negative integer and not greater than maxSandboxCount. Historical values can exceed 100 and are not truncated when read. However, newly written complete configurations must still meet the 0 to 100 range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>The type of the service endpoint. DEFAULT indicates a default endpoint created and maintained by the platform. NAMED indicates a named endpoint explicitly created by a user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAMED</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The name of the service endpoint. The name must be unique within the workspace and 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-endpoint</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The expected public inbound access configured by the user on the service endpoint. For historical service endpoints that have not been configured, true is returned. This only indicates the configuration expectation. The actual availability of the public IP address is subject to accessUrls and status.</para>
            /// </summary>
            [NameInMap("publicAccessEnabled")]
            [Validation(Required=false)]
            public bool? PublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the region where the service endpoint resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-123456</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

            /// <summary>
            /// <para>The status of the service endpoint. Valid values: CREATING, READY, UPDATING, DEGRADED, DISABLED, and DELETING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the service endpoint status. Returns the specific reason when the status is abnormal.</para>
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
            public ListServiceEndpointsResponseBodyItemsTarget Target { get; set; }
            public class ListServiceEndpointsResponseBodyItemsTarget : TeaModel {
                /// <summary>
                /// <para>The ID of the target agent. Returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-123456</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The version number of the target agent. Returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("agentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// <para>The type of the collaboration component. Returned when the target type is TEAM_COLLABORATION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ELEMENT_WEB</para>
                /// </summary>
                [NameInMap("collaborationComponent")]
                [Validation(Required=false)]
                public string CollaborationComponent { get; set; }

                /// <summary>
                /// <para>The workspace resource binding ID associated with the target collaboration component. Returned when the target type is TEAM_COLLABORATION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wrb-123456</para>
                /// </summary>
                [NameInMap("resourceBindingId")]
                [Validation(Required=false)]
                public string ResourceBindingId { get; set; }

                /// <summary>
                /// <para>The target type. Valid values: AGENT_VERSION and TEAM_COLLABORATION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT_VERSION</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The time of the last modification in UTC format compliant with RFC 3339.</para>
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
        /// <para>The maximum number of records per page that takes effect in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. Returns an error description if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The cursor for the next page. This parameter is empty if there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6YWdlbnRjb3JlLnNlcnZpY2UtZW5kcG9pbnQubGlzdDoyMA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of service endpoints that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
