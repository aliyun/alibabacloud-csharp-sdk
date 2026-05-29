// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListDesktopAgentRuntimeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDesktopAgentRuntimeResponseBodyData> Data { get; set; }
        public class ListDesktopAgentRuntimeResponseBodyData : TeaModel {
            [NameInMap("AgentImInfo")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataAgentImInfo AgentImInfo { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataAgentImInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("AgentImStatus")]
                [Validation(Required=false)]
                public string AgentImStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("CloudSpaceStatus")]
                [Validation(Required=false)]
                public string CloudSpaceStatus { get; set; }

            }

            [NameInMap("AgentInstanceInfoList")]
            [Validation(Required=false)]
            public List<ListDesktopAgentRuntimeResponseBodyDataAgentInstanceInfoList> AgentInstanceInfoList { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataAgentInstanceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("AgentInstanceStatus")]
                [Validation(Required=false)]
                public string AgentInstanceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026.3.13</para>
                /// </summary>
                [NameInMap("AgentInstanceVersion")]
                [Validation(Required=false)]
                public string AgentInstanceVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChannelConfigure")]
                [Validation(Required=false)]
                public bool? ChannelConfigure { get; set; }

                [NameInMap("ChannelConfiguredList")]
                [Validation(Required=false)]
                public List<string> ChannelConfiguredList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("DeploymentSource")]
                [Validation(Required=false)]
                public string DeploymentSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModelConfigure")]
                [Validation(Required=false)]
                public bool? ModelConfigure { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mt-xxxx</para>
                /// </summary>
                [NameInMap("ModelTemplateId")]
                [Validation(Required=false)]
                public string ModelTemplateId { get; set; }

            }

            [NameInMap("AuthUsers")]
            [Validation(Required=false)]
            public List<string> AuthUsers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChannelConfigure")]
            [Validation(Required=false)]
            public bool? ChannelConfigure { get; set; }

            [NameInMap("ChannelConfiguredList")]
            [Validation(Required=false)]
            public List<string> ChannelConfiguredList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-xxxx</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Agent-001</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAuthUser")]
            [Validation(Required=false)]
            public bool? HasAuthUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModelConfigure")]
            [Validation(Required=false)]
            public bool? ModelConfigure { get; set; }

            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("QrCodeConfiguringList")]
            [Validation(Required=false)]
            public List<string> QrCodeConfiguringList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataResourceGroup ResourceGroup { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataResourceGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-xxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>resource-group-001</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-xxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("RiskInfo")]
            [Validation(Required=false)]
            public ListDesktopAgentRuntimeResponseBodyDataRiskInfo RiskInfo { get; set; }
            public class ListDesktopAgentRuntimeResponseBodyDataRiskInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AgentUninstalled")]
                [Validation(Required=false)]
                public bool? AgentUninstalled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChannelModified")]
                [Validation(Required=false)]
                public bool? ChannelModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModelModified")]
                [Validation(Required=false)]
                public bool? ModelModified { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
