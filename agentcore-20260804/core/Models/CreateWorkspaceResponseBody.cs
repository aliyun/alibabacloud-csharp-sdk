// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateWorkspaceResponseBody : TeaModel {
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
        public CreateWorkspaceResponseBodyData Data { get; set; }
        public class CreateWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AI Registry namespace ID. It is returned after related resources are bound and may be empty during initialization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespace-0123456789abcdef</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("aiRegistryNamespaceId")]
            [Validation(Required=false)]
            public string AiRegistryNamespaceId { get; set; }

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
            /// <para>The CloudMonitor workspace ID. It is returned after related resources are bound and may be empty during initialization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms-ws-0123456789abcdef</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("cmsWorkspaceId")]
            [Validation(Required=false)]
            public string CmsWorkspaceId { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created, in ISO 8601 format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-28T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
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
            public CreateWorkspaceResponseBodyDataNetworkConfiguration NetworkConfiguration { get; set; }
            public class CreateWorkspaceResponseBodyDataNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is still in progress, and UpdateFailed indicates that the current change failed. This parameter only controls whether the latest versions of managed and custom agents use the public network egress of the platform. It does not control fixed historical versions, model or MCP proxy egress, or the public network egress of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is in progress, and UpdateFailed indicates that the change failed. When disabled, the public network ingress for all agent endpoints in the workspace is closed. The original public network ingress is restored when re-enabled. INNER_DIRECT and user VPC ingress are not affected. Collaboration and Element Web ingress are not controlled by this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicIngressEnabled")]
                [Validation(Required=false)]
                public bool? PublicIngressEnabled { get; set; }

                /// <summary>
                /// <para>The user VPC network configuration.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public CreateWorkspaceResponseBodyDataNetworkConfigurationVpc Vpc { get; set; }
                public class CreateWorkspaceResponseBodyDataNetworkConfigurationVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the VPC network.</para>
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
                    /// <para>The user VPC ID.</para>
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
            /// <para>The ID of the region where the workspace resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the workspace belongs. It may be empty if no resource group is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm1234567890</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initialized</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The supplementary reason for the current status of the workspace. It is used to display the specific reason when initialization fails or when waiting for authorization. It may be empty under normal circumstances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Waiting for OSS RAM authorization</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
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
            /// <para>The list of tags for the workspace. An empty array is returned if no tags are set.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResponseBodyDataTags> Tags { get; set; }
            public class CreateWorkspaceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>environment</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>development</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the tenant.</para>
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
