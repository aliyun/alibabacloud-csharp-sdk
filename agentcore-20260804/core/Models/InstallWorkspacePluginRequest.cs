// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class InstallWorkspacePluginRequest : TeaModel {
        /// <summary>
        /// <para>The request body for installing a plugin.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public InstallWorkspacePluginRequestBody Body { get; set; }
        public class InstallWorkspacePluginRequestBody : TeaModel {
            /// <summary>
            /// <para>The plugin-specific configuration. The configuration structure is determined by pluginName. Currently, the collaboration plugin supports network.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public InstallWorkspacePluginRequestBodyConfig Config { get; set; }
            public class InstallWorkspacePluginRequestBodyConfig : TeaModel {
                /// <summary>
                /// <para>The network configuration used by the collaboration plugin. If not specified, the server uses the existing network configuration of the workspace.</para>
                /// </summary>
                [NameInMap("network")]
                [Validation(Required=false)]
                public InstallWorkspacePluginRequestBodyConfigNetwork Network { get; set; }
                public class InstallWorkspacePluginRequestBodyConfigNetwork : TeaModel {
                    /// <summary>
                    /// <para>Controls whether the collaboration component is allowed to access the public network. This configuration only controls public network access capability and does not expose the component service to the public network.</para>
                    /// </summary>
                    [NameInMap("internet")]
                    [Validation(Required=false)]
                    public InstallWorkspacePluginRequestBodyConfigNetworkInternet Internet { get; set; }
                    public class InstallWorkspacePluginRequestBodyConfigNetworkInternet : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable public network access. If set to true without a VPC specified, PUB_NET is used. If set to true with a VPC specified, PRIVATE_PUBNET is used. If only a VPC is specified, PRIVATE_NET is used. At least one of public network or VPC must be configured.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                    /// <summary>
                    /// <para>The user VPC and vSwitch list used for deploying the collaboration plugin. The zones corresponding to the vSwitches are queried by the server and do not need to be provided by the user.</para>
                    /// </summary>
                    [NameInMap("vpc")]
                    [Validation(Required=false)]
                    public InstallWorkspacePluginRequestBodyConfigNetworkVpc Vpc { get; set; }
                    public class InstallWorkspacePluginRequestBodyConfigNetworkVpc : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the collaboration plugin uses VPC networking. If set to false, vpcId and vSwitchIds are ignored. If set to true, you must provide both vpcId and at least two vSwitchIds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The list of vSwitch IDs. The collaboration plugin requires that the vSwitches cover at least two different zones, and all vSwitches must belong to the VPC specified by vpcId.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("vSwitchIds")]
                        [Validation(Required=false)]
                        public List<string> VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// <para>This parameter is required.</para>
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

        }

        /// <summary>
        /// <para>The client idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-plugin-install-20260810-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
