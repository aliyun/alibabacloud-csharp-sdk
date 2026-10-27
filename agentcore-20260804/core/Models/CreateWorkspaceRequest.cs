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
            /// <para>If specified, the workspace is directly bound to this AgentSpace without creating a new one. The associated CloudMonitor (CMS) workspace is determined by the server\&quot;s reverse lookup result, and CmsWorkspace validation is skipped. When the workspace is deleted, only the binding is removed, and the AgentSpace is not deleted. The value must match the current account and region, and the associated CMS workspace must be found through reverse lookup. Otherwise, InvalidParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-space</para>
            /// </summary>
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            /// <summary>
            /// <para>If specified, the workspace is bound to this CloudMonitor (CMS) workspace without creating a new one. When the workspace is deleted, only the binding is removed, and the CMS workspace is not deleted. The value must match the current account and region. Otherwise, InvalidParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-cms-workspace</para>
            /// </summary>
            [NameInMap("cmsWorkspace")]
            [Validation(Required=false)]
            public string CmsWorkspace { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
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
                /// <para>Specifies whether to allow public outbound access from the platform. If not specified, the default value is true. This setting only controls whether the latest versions of managed and custom agents use the public outbound endpoint of the platform. It does not affect fixed historical versions, model or Model Context Protocol (MCP) proxy outbound endpoints, or the public outbound endpoint of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow public inbound access. If not specified, the default value is true. If disabled, the public inbound endpoints of all agent endpoints in the workspace are closed. If re-enabled, the original public inbound endpoints are restored. INNER_DIRECT and user VPC inbound endpoints are not affected. Collaboration and Element Web inbound endpoints are not controlled by this setting.</para>
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
                    /// <para>The list of vSwitch IDs. If the VPC network is enabled, at least one vSwitch must be included, and all vSwitches must belong to the VPC specified by VpcId.</para>
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
            /// <para>The storage type of the workspace. PLATFORM indicates platform-managed storage. PRIVATE indicates user-owned private Object Storage Service (OSS) storage.</para>
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
