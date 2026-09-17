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
            /// <para>The AI Registry namespace ID. This value is returned after the related resources are bound. It may be empty during initialization.</para>
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
            /// <para>The CloudMonitor workspace ID. This value is returned after the related resources are bound. It may be empty during initialization.</para>
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
            public CreateWorkspaceResponseBodyDataNetworkConfiguration NetworkConfiguration { get; set; }
            public class CreateWorkspaceResponseBodyDataNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>The VPC network configuration of the user.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public CreateWorkspaceResponseBodyDataNetworkConfigurationVpc Vpc { get; set; }
                public class CreateWorkspaceResponseBodyDataNetworkConfigurationVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable VPC networking.</para>
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
                    /// <para>The ID of the user VPC.</para>
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
            /// <para>The ID of the resource group to which the workspace belongs. This value may be empty if no resource group is specified.</para>
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
            /// <para>The workspace status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initialized</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The supplementary reason for the current workspace status. This value is used to display the specific reason when initialization fails or authorization is pending. It may be empty under normal conditions.</para>
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
            /// <para>The list of workspace tags. An empty array is returned if no tags are set.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
