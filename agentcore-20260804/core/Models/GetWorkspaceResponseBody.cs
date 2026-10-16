// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
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
        /// <para>The workspace details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetWorkspaceResponseBodyData Data { get; set; }
        public class GetWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The OSS storage authorization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTHORIZED</para>
            /// </summary>
            [NameInMap("authorizationStatus")]
            [Validation(Required=false)]
            public string AuthorizationStatus { get; set; }

            /// <summary>
            /// <para>The name of the private OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucket-001</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-06T03:56:56Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production-agents</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network configuration of the workspace.</para>
            /// </summary>
            [NameInMap("networkConfiguration")]
            [Validation(Required=false)]
            public GetWorkspaceResponseBodyDataNetworkConfiguration NetworkConfiguration { get; set; }
            public class GetWorkspaceResponseBodyDataNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is still being executed, and UpdateFailed indicates that the current change failed. This setting only controls the use of the platform public egress for the latest versions of managed and custom agents. It does not control fixed historical versions, model or MCP proxy egress, or the public egress of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>The public egress IP address of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203.0.113.10</para>
                /// </summary>
                [NameInMap("publicEgressIp")]
                [Validation(Required=false)]
                public string PublicEgressIp { get; set; }

                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is in progress, and UpdateFailed indicates that the change failed. When disabled, the public ingress for all agent endpoints in the workspace is closed. When re-enabled, the original public ingress is restored. INNER_DIRECT and user VPC ingress are not affected. Collaboration and Element Web ingress are not controlled by this setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicIngressEnabled")]
                [Validation(Required=false)]
                public bool? PublicIngressEnabled { get; set; }

                /// <summary>
                /// <para>The VPC network configuration of the user.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public GetWorkspaceResponseBodyDataNetworkConfigurationVpc Vpc { get; set; }
                public class GetWorkspaceResponseBodyDataNetworkConfigurationVpc : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the VPC network is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The list of vSwitch IDs.</para>
                    /// </summary>
                    [NameInMap("vSwitchIds")]
                    [Validation(Required=false)]
                    public List<string> VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The VPC ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1234567890</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The region ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The workspace status. Valid values: Initializing, InitializationFailed, Initialized, Deleting, and Deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initialized</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the workspace status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InitializationFailed: VPC not found</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The storage type of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the workspace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenant-123456</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

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
        /// <para>The response message.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
