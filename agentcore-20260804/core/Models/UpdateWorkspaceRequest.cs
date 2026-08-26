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
            /// <para>The updated workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production-agents-v2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The updated workspace network configuration.</para>
            /// </summary>
            [NameInMap("networkConfiguration")]
            [Validation(Required=false)]
            public UpdateWorkspaceRequestBodyNetworkConfiguration NetworkConfiguration { get; set; }
            public class UpdateWorkspaceRequestBodyNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>The user VPC network configuration.</para>
                /// <para>This parameter is required.</para>
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
