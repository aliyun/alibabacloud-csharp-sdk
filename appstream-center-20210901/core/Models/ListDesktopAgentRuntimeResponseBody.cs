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
                /// <para>The online status of the agent IM. Valid values: Online and Offline. Default value: Offline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Online</para>
                /// </summary>
                [NameInMap("AgentImOnlineStatus")]
                [Validation(Required=false)]
                public string AgentImOnlineStatus { get; set; }

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

                /// <summary>
                /// <para>The Agent platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
                /// </summary>
                [NameInMap("AgentPlatform")]
                [Validation(Required=false)]
                public string AgentPlatform { get; set; }

                /// <summary>
                /// <para>The agent provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgenticComputer</para>
                /// </summary>
                [NameInMap("AgentProvider")]
                [Validation(Required=false)]
                public string AgentProvider { get; set; }

                /// <summary>
                /// <para>Indicates whether a third-party channel is configured for the agent instance.</para>
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
                /// <para>The latest reported MindCenter version in the instance properties. This value is null if the version is not reported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.3.20-D-20261105.181002</para>
                /// </summary>
                [NameInMap("MindCenterVersion")]
                [Validation(Required=false)]
                public string MindCenterVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether a model is configured for the agent instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModelConfigure")]
                [Validation(Required=false)]
                public bool? ModelConfigure { get; set; }

                /// <summary>
                /// <para>The ID of the configured model group.</para>
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
            /// <para>Indicates whether a third-party channel is configured for the agent runtime.</para>
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
            /// <para>The Agent runtime name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent-001</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The cloud desktop status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether users are authorized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAuthUser")]
            [Validation(Required=false)]
            public bool? HasAuthUser { get; set; }

            /// <summary>
            /// <para>The list of management statuses parsed from the aggregated managementStatus value.</para>
            /// </summary>
            [NameInMap("ManagementStatuses")]
            [Validation(Required=false)]
            public List<string> ManagementStatuses { get; set; }

            /// <summary>
            /// <para>Indicates whether a model is configured for the agent runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModelConfigure")]
            [Validation(Required=false)]
            public bool? ModelConfigure { get; set; }

            /// <summary>
            /// <para>The ID of the effective model template. This parameter is returned only when modelConfigure is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the effective model template. This parameter is returned only when modelConfigure is set to true.</para>
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
            /// <para>The list of channel codes in the QR code configuration.</para>
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
            /// <para>The region location (mainland China or overseas).</para>
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
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>resource-group-001</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// <para>The resource ID, which is the cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The risk information. This parameter is returned only when the IncludeRiskInfo request parameter is set to true. Otherwise, null is returned.</para>
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
                /// <para>Indicates whether the third-party channel configuration is modified and inconsistent with the configuration delivered by the administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChannelModified")]
                [Validation(Required=false)]
                public bool? ChannelModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the model configuration is modified and inconsistent with the configuration delivered by the administrator.</para>
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
        /// <para>The page size.</para>
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
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
