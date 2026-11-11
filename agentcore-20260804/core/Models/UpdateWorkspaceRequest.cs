// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating a workspace.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateWorkspaceRequestBody Body { get; set; }
        public class UpdateWorkspaceRequestBody : TeaModel {
            /// <summary>
            /// <para>The updated name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production-agents-v2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The updated network configuration of the workspace.</para>
            /// </summary>
            [NameInMap("networkConfiguration")]
            [Validation(Required=false)]
            public UpdateWorkspaceRequestBodyNetworkConfiguration NetworkConfiguration { get; set; }
            public class UpdateWorkspaceRequestBodyNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow public outbound access from the platform. If this parameter is not specified, the original value is retained. Disabling this feature asynchronously cascades to disable the public network switch for agents. Re-enabling it does not automatically restore the agent switch. This parameter only controls whether the latest versions of managed and custom agents use the public outbound gateway of the platform. It does not control fixed historical versions, model or MCP proxy gateways, or the public outbound gateway of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow public inbound access. If this parameter is not specified, the original value is retained. This parameter can be modified together with PublicEgressEnabled and takes effect asynchronously through a unified task. Disabling this feature closes the public inbound endpoints for all agent endpoints in the workspace. Re-enabling it restores the original public inbound endpoints. INNER_DIRECT and user VPC endpoints are not affected. Collaboration and Element Web endpoints are not controlled by this parameter.</para>
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
                public UpdateWorkspaceRequestBodyNetworkConfigurationVpc Vpc { get; set; }
                public class UpdateWorkspaceRequestBodyNetworkConfigurationVpc : TeaModel {
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
                    /// <para>The list of vSwitch IDs. When VPC networking is enabled, at least one vSwitch must be included, and all vSwitches must belong to the VPC specified by VpcId.</para>
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

        }

        /// <summary>
        /// <para>The client idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-update-20260805-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
