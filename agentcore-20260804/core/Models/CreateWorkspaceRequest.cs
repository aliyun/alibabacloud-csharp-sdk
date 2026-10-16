// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace creation request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateWorkspaceRequestBody Body { get; set; }
        public class CreateWorkspaceRequestBody : TeaModel {
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
                /// <para>Specifies whether to allow public outbound access from the platform. If this parameter is not specified, the default value is true. This setting only controls whether the latest versions of managed and custom agents use the public outbound endpoint of the platform. It does not affect fixed historical versions, model or MCP proxy endpoints, or the public outbound endpoint of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow public inbound access. If this parameter is not specified, the default value is true. If disabled, the public inbound endpoints of all agent endpoints in the workspace are closed, and the original public inbound endpoints are restored when re-enabled. INNER_DIRECT and user VPC endpoints are not affected. Collaboration and Element Web endpoints are not controlled by this parameter.</para>
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
                    /// <para>The list of vSwitch IDs. When the VPC network is enabled, the list must contain at least one vSwitch, and all vSwitches must belong to the VPC specified by VpcId.</para>
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
            /// <para>The workspace storage type. PLATFORM indicates platform-managed storage, and PRIVATE indicates user private OSS storage.</para>
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
