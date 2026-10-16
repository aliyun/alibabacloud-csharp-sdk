// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The workspace list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyItems> Items { get; set; }
        public class ListWorkspacesResponseBodyItems : TeaModel {
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
            public ListWorkspacesResponseBodyItemsNetworkConfiguration NetworkConfiguration { get; set; }
            public class ListWorkspacesResponseBodyItemsNetworkConfiguration : TeaModel {
                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is still in progress, and UpdateFailed indicates that the current change failed. This setting only controls whether the latest versions of managed and custom agents use the public network egress of the platform. It does not control fixed historical versions, model or MCP proxy egresses, or the public network egress of the user VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicEgressEnabled")]
                [Validation(Required=false)]
                public bool? PublicEgressEnabled { get; set; }

                /// <summary>
                /// <para>Returns the target configuration value. Updating indicates that the change is in progress, and UpdateFailed indicates that the change failed. After this setting is disabled, the public network ingress for all agent endpoints in the workspace is closed. After it is re-enabled, the original public network ingress is restored. INNER_DIRECT and user VPC ingress are not affected. Collaboration and Element Web ingress are not controlled by this setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("publicIngressEnabled")]
                [Validation(Required=false)]
                public bool? PublicIngressEnabled { get; set; }

                /// <summary>
                /// <para>The network configuration of the user VPC.</para>
                /// </summary>
                [NameInMap("vpc")]
                [Validation(Required=false)]
                public ListWorkspacesResponseBodyItemsNetworkConfigurationVpc Vpc { get; set; }
                public class ListWorkspacesResponseBodyItemsNetworkConfigurationVpc : TeaModel {
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
            /// <para>The ID of the region where the workspace resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The workspace status. Valid values: Initializing, Initialized, Deleting, and Deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initialized</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The maximum number of records per page used for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para>The cursor for the next page. This parameter is empty if there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d29ya3NwYWNlLW9mZnNldDo0MA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of workspaces that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
