// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListDesktopAgentRuntimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned result objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDesktopAgentRuntimeResponseBodyData> Data { get; set; }
        public class ListDesktopAgentRuntimeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent IM information.</para>
            /// </summary>
            [NameInMap("AgentImInfo")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataAgentImInfo AgentImInfo { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataAgentImInfo : TeaModel {
                /// <summary>
                /// <para>The agent IM status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("AgentImStatus")]
                [Validation(Required=false)]
                public string AgentImStatus { get; set; }

                /// <summary>
                /// <para>The CloudSpace status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("CloudSpaceStatus")]
                [Validation(Required=false)]
                public string CloudSpaceStatus { get; set; }

            }

            /// <summary>
            /// <para>The list of agent instance information.</para>
            /// </summary>
            [NameInMap("AgentInstanceInfoList")]
            [Validation(Required=false)]
            public List<ListDesktopAgentRuntimeResponseBodyDataAgentInstanceInfoList> AgentInstanceInfoList { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataAgentInstanceInfoList : TeaModel {
                /// <summary>
                /// <para>The agent instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("AgentInstanceStatus")]
                [Validation(Required=false)]
                public string AgentInstanceStatus { get; set; }

                /// <summary>
                /// <para>The agent instance version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026.3.13</para>
                /// </summary>
                [NameInMap("AgentInstanceVersion")]
                [Validation(Required=false)]
                public string AgentInstanceVersion { get; set; }

                [NameInMap("AgentPlatform")]
                [Validation(Required=false)]
                public string AgentPlatform { get; set; }

                [NameInMap("AgentProvider")]
                [Validation(Required=false)]
                public string AgentProvider { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent instance has a configured third-party channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChannelConfigure")]
                [Validation(Required=false)]
                public bool? ChannelConfigure { get; set; }

                /// <summary>
                /// <para>The list of third-party channels configured for the agent instance.</para>
                /// </summary>
                [NameInMap("ChannelConfiguredList")]
                [Validation(Required=false)]
                public List<string> ChannelConfiguredList { get; set; }

                /// <summary>
                /// <para>The deployment source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("DeploymentSource")]
                [Validation(Required=false)]
                public string DeploymentSource { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent instance has a configured model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModelConfigure")]
                [Validation(Required=false)]
                public bool? ModelConfigure { get; set; }

                /// <summary>
                /// <para>The configured model group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mt-xxxx</para>
                /// </summary>
                [NameInMap("ModelTemplateId")]
                [Validation(Required=false)]
                public string ModelTemplateId { get; set; }

            }

            /// <summary>
            /// <para>The list of authorized users.</para>
            /// </summary>
            [NameInMap("AuthUsers")]
            [Validation(Required=false)]
            public List<string> AuthUsers { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent runtime has a configured third-party channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChannelConfigure")]
            [Validation(Required=false)]
            public bool? ChannelConfigure { get; set; }

            /// <summary>
            /// <para>The list of third-party channels configured for the agent runtime.</para>
            /// </summary>
            [NameInMap("ChannelConfiguredList")]
            [Validation(Required=false)]
            public List<string> ChannelConfiguredList { get; set; }

            /// <summary>
            /// <para>The agent runtime ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xxxx</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The agent runtime name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent-001</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The cloud computer status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether authorized users exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAuthUser")]
            [Validation(Required=false)]
            public bool? HasAuthUser { get; set; }

            [NameInMap("ManagementStatuses")]
            [Validation(Required=false)]
            public List<string> ManagementStatuses { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent runtime has a configured model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModelConfigure")]
            [Validation(Required=false)]
            public bool? ModelConfigure { get; set; }

            /// <summary>
            /// <para>The effective model template ID (returned only when modelConfigure=true).</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <para>The effective model template name (returned only when modelConfigure=true).</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-template-001</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The list of channels in QR code configuration.</para>
            /// </summary>
            [NameInMap("QrCodeConfiguringList")]
            [Validation(Required=false)]
            public List<string> QrCodeConfiguringList { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The region location (domestic/overseas).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mainland</para>
            /// </summary>
            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// <para>The resource group information.</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataResourceGroup ResourceGroup { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataResourceGroup : TeaModel {
                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-xxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>resource-group-001</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// <para>The resource ID, which is the cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The risk information (returned only when the request parameter IncludeRiskInfo is set to true, otherwise null).</para>
            /// </summary>
            [NameInMap("RiskInfo")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataRiskInfo RiskInfo { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataRiskInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the agent is uninstalled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AgentUninstalled")]
                [Validation(Required=false)]
                public bool? AgentUninstalled { get; set; }

                /// <summary>
                /// <para>Indicates whether the third-party channel configuration is modified (inconsistent with the admin-distributed configuration).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChannelModified")]
                [Validation(Required=false)]
                public bool? ChannelModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the model configuration is modified (inconsistent with the admin-distributed configuration).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModelModified")]
                [Validation(Required=false)]
                public bool? ModelModified { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
