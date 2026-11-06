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
                /// <para>The reason for the access URL status. The specific reason is returned when the status is abnormal.</para>
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
                /// <para>The authentication method. NONE indicates that no authentication is required. API_KEY indicates that authentication is performed by passing an API key in the <c>x-api-key</c> request header.</para>
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
            /// <para>publicAccessEnabled 与工作空间公网入向上限叠加后的结果：二者均允许时为 true。仅表示策略目标，不代表公网入口已发布完成，实际状态以 accessUrls 与 status 为准。</para>
            /// </summary>
            [NameInMap("effectivePublicAccessEnabled")]
            [Validation(Required=false)]
            public bool? EffectivePublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>仅在服务端点设置过弹性覆盖值时返回，可设置的为 Router 类型服务端点与 GATEWAY_API_WITH_VPC_INGRESS 类型的 DEFAULT 服务端点；未设置覆盖值时不返回该对象，表示继承智能体源配置，不得当作空对象或默认策略。返回时三个字段必全。</para>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public ListServiceEndpointsResponseBodyItemsElasticityPolicy ElasticityPolicy { get; set; }
            public class ListServiceEndpointsResponseBodyItemsElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>是否开启弹性。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>最大实例数，不小于 1。</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>最小实例数，不小于 0 且不大于 maxSandboxCount。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>The type of the service endpoint. DEFAULT indicates a default endpoint created and maintained by the platform. NAMED indicates a named endpoint explicitly created by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAMED</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The name of the service endpoint. The name must be unique within the workspace and be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-endpoint</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>用户在服务端点上设置的公网入向期望；未设置过的历史服务端点按 true 返回。仅表示配置期望，实际公网地址是否可用以 accessUrls 与 status 为准。</para>
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
            /// <para>The reason for the service endpoint status. The specific reason is returned when the status is abnormal.</para>
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
                /// <para>The ID of the target agent. This parameter is returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-123456</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The version of the target agent. This parameter is returned when the target type is AGENT_VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("agentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// <para>The type of the collaboration component. This parameter is returned when the target type is TEAM_COLLABORATION.</para>
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
        /// <para>The maximum number of entries returned on a single page for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The cursor for the next page. This parameter is empty if no next page exists.</para>
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
