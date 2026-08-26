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
                /// <para>The VPC network configuration of the user.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public CreateWorkspaceRequestBodyNetworkConfigurationVpc Vpc { get; set; }
                public class CreateWorkspaceRequestBodyNetworkConfigurationVpc : TeaModel {
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
                    /// <para>The ID of the VPC.</para>
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
        /// <para>workspace-create-20260805-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
