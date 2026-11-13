// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a workspace.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateWorkspaceRequestBody Body { get; set; }
        public class CreateWorkspaceRequestBody : TeaModel {
            /// <summary>
            /// <para>If this parameter is specified, the workspace is directly bound to the specified AgentSpace, and a new one is not created. The CMS workspace to which it belongs is determined by the server reverse lookup result, and CmsWorkspace does not need to be verified. When the workspace is deleted, it is only unbound, and the AgentSpace is not deleted. The value must match the current account and region, and the associated CMS workspace must be found through reverse lookup. Otherwise, InvalidParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-space</para>
            /// </summary>
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            /// <summary>
            /// <para>If this parameter is specified, the workspace is bound to the specified CMS workspace, and the platform does not create a new one. When the workspace is deleted, it is only unbound, and the CMS workspace is not deleted. The value must match the current account and region. Otherwise, InvalidParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-cms-workspace</para>
            /// </summary>
            [NameInMap("cmsWorkspace")]
            [Validation(Required=false)]
            public string CmsWorkspace { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// <para>This parameter is required.</para>
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
            public CreateWorkspaceRequestBodyNetworkConfiguration NetworkConfiguration { get; set; }
            public class CreateWorkspaceRequestBodyNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow public egress access from the platform. If this parameter is not specified, the default value is true. This parameter only controls whether the latest versions of managed and custom agents use the public egress of the platform. It does not control fixed historical versions, model or MCP proxy egress, or the public egress of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow public ingress access. If this parameter is not specified, the default value is true. If this parameter is set to false, the public ingress of all agent endpoints in the workspace is disabled. If this parameter is set to true again, the original public ingress is restored. INNER_DIRECT and user VPC ingress are not affected. Collaboration and Element Web ingress are not controlled by this parameter. If this parameter is set to false, the workspace VPC must be enabled.</para>
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
                public CreateWorkspaceRequestBodyNetworkConfigurationVpc Vpc { get; set; }
                public class CreateWorkspaceRequestBodyNetworkConfigurationVpc : TeaModel {
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
                    /// <para>The list of vSwitch IDs. When the VPC network is enabled, at least one vSwitch must be included, and all vSwitches must belong to the VPC specified by VpcId.</para>
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
            /// <para>The storage type of the workspace. PLATFORM indicates platform-managed storage, and PRIVATE indicates user private OSS storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The client idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-create-20260805-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
