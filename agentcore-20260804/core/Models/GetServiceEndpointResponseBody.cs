// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetServiceEndpointResponseBody : TeaModel {
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
        /// <para>The service endpoint details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceEndpointResponseBodyData Data { get; set; }
        public class GetServiceEndpointResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of access URLs for the service endpoint.</para>
            /// </summary>
            [NameInMap("accessUrls")]
            [Validation(Required=false)]
            public List<GetServiceEndpointResponseBodyDataAccessUrls> AccessUrls { get; set; }
            public class GetServiceEndpointResponseBodyDataAccessUrls : TeaModel {
                /// <summary>
                /// <para>The access URL type. Valid values: INTERNET and VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INTERNET</para>
                /// </summary>
                [NameInMap("accessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The access URL status. Valid values: CREATING, READY, and DEGRADED.</para>
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
            public GetServiceEndpointResponseBodyDataAuthentication Authentication { get; set; }
            public class GetServiceEndpointResponseBodyDataAuthentication : TeaModel {
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
            /// <para>The result of combining publicAccessEnabled with the public inbound access upper limit of the workspace. The value is true only when both allow public inbound access. This field only indicates the policy target and does not mean that the public endpoint has been published. The actual status is subject to accessUrls and status.</para>
            /// </summary>
            [NameInMap("effectivePublicAccessEnabled")]
            [Validation(Required=false)]
            public bool? EffectivePublicAccessEnabled { get; set; }

            /// <summary>
            /// <para>This object is returned only when elastic override values are configured for the service endpoint. You can configure override values for Router-type service endpoints and DEFAULT service endpoints of the GATEWAY_API_WITH_VPC_INGRESS type. If no override values are configured, this object is not returned, which indicates that the source configuration of the agent is inherited. Do not treat the absence of this object as an empty object or a default policy. When this object is returned, all three fields are included.</para>
            /// </summary>
            [NameInMap("elasticityPolicy")]
            [Validation(Required=false)]
            public GetServiceEndpointResponseBodyDataElasticityPolicy ElasticityPolicy { get; set; }
            public class GetServiceEndpointResponseBodyDataElasticityPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether elasticity is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The maximum number of instances. The value must be greater than or equal to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("maxSandboxCount")]
                [Validation(Required=false)]
                public int? MaxSandboxCount { get; set; }

                /// <summary>
                /// <para>The minimum number of instances. The value must be greater than or equal to 0 and less than or equal to the value of maxSandboxCount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minSandboxCount")]
                [Validation(Required=false)]
                public int? MinSandboxCount { get; set; }

            }

            /// <summary>
            /// <para>The service endpoint type. DEFAULT indicates the default endpoint created and maintained by the platform. NAMED indicates the named endpoint explicitly created by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAMED</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The service endpoint name. The name must be unique within the workspace and be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-endpoint</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The expected public inbound access configured by the user on the service endpoint. For historical service endpoints where this value is not configured, true is returned. This field only indicates the configuration expectation. The actual availability of the public URL is subject to accessUrls and status.</para>
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
            /// <para>The service endpoint status. Valid values: CREATING, READY, UPDATING, DEGRADED, DISABLED, and DELETING.</para>
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
            /// <para>The target route configuration of the service endpoint.</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public GetServiceEndpointResponseBodyDataTarget Target { get; set; }
            public class GetServiceEndpointResponseBodyDataTarget : TeaModel {
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
                /// <para>The target agent version number. This parameter is returned when the target type is AGENT_VERSION.</para>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
