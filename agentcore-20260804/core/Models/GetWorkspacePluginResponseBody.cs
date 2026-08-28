// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetWorkspacePluginResponseBody : TeaModel {
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
        /// <para>The plug-in details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetWorkspacePluginResponseBodyData Data { get; set; }
        public class GetWorkspacePluginResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The user-configurable properties currently in effect for the plug-in. This field is empty if the plug-in is not installed.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetWorkspacePluginResponseBodyDataConfig Config { get; set; }
            public class GetWorkspacePluginResponseBodyDataConfig : TeaModel {
                /// <summary>
                /// <para>The AgentLoop plug-in configuration.</para>
                /// </summary>
                [NameInMap("agentLoop")]
                [Validation(Required=false)]
                public GetWorkspacePluginResponseBodyDataConfigAgentLoop AgentLoop { get; set; }
                public class GetWorkspacePluginResponseBodyDataConfigAgentLoop : TeaModel {
                    /// <summary>
                    /// <para>The AgentSpace name associated with the AgentLoop plug-in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agentcore-ws-123456</para>
                    /// </summary>
                    [NameInMap("agentSpaceName")]
                    [Validation(Required=false)]
                    public string AgentSpaceName { get; set; }

                    /// <summary>
                    /// <para>The creation time of the AgentSpace in UTC in RFC 3339 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-08-12T03:04:05Z</para>
                    /// </summary>
                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    /// <summary>
                    /// <para>The region ID where the AgentSpace resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// <para>The network configuration of the plug-in, including public network access configuration and VPC configuration.</para>
                /// </summary>
                [NameInMap("network")]
                [Validation(Required=false)]
                public GetWorkspacePluginResponseBodyDataConfigNetwork Network { get; set; }
                public class GetWorkspacePluginResponseBodyDataConfigNetwork : TeaModel {
                    /// <summary>
                    /// <para>The public network access configuration.</para>
                    /// </summary>
                    [NameInMap("internet")]
                    [Validation(Required=false)]
                    public GetWorkspacePluginResponseBodyDataConfigNetworkInternet Internet { get; set; }
                    public class GetWorkspacePluginResponseBodyDataConfigNetworkInternet : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether public network access is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                    /// <summary>
                    /// <para>The user VPC configuration.</para>
                    /// </summary>
                    [NameInMap("vpc")]
                    [Validation(Required=false)]
                    public GetWorkspacePluginResponseBodyDataConfigNetworkVpc Vpc { get; set; }
                    public class GetWorkspacePluginResponseBodyDataConfigNetworkVpc : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether VPC network access is enabled for the collaboration plug-in.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The list of vSwitch IDs used for plug-in deployment.</para>
                        /// </summary>
                        [NameInMap("vSwitchIds")]
                        [Validation(Required=false)]
                        public List<string> VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The VPC ID used for plug-in deployment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1example</para>
                        /// </summary>
                        [NameInMap("vpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>Indicates whether the plug-in is enabled. The value is true when the status is ENABLED.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>collaboration</para>
            /// </summary>
            [NameInMap("pluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>The plug-in status. Valid values: DISABLED, ENABLING, ENABLED, ENABLE_FAILED, DISABLING, DISABLE_FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The response message. An error description is returned if the request fails.</para>
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
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
