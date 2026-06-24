// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListDesktopAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>The list of agent instance statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("AgentInstanceStatuses")]
        [Validation(Required=false)]
        public List<string> AgentInstanceStatuses { get; set; }

        /// <summary>
        /// <para>The list of agent instance versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw 2026.4.15</para>
        /// </summary>
        [NameInMap("AgentInstanceVersions")]
        [Validation(Required=false)]
        public List<string> AgentInstanceVersions { get; set; }

        /// <summary>
        /// <para>The agent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The name of the agent provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The list of authorized users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user001</para>
        /// </summary>
        [NameInMap("AuthUsers")]
        [Validation(Required=false)]
        public List<string> AuthUsers { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>Specifies whether the third-party channel is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ChannelConfigure")]
        [Validation(Required=false)]
        public bool? ChannelConfigure { get; set; }

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
        /// <para>The list of agent runtime IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jvs-xxxxx</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The list of agent runtime names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop001</para>
        /// </summary>
        [NameInMap("DesktopNames")]
        [Validation(Required=false)]
        public List<string> DesktopNames { get; set; }

        /// <summary>
        /// <para>The list of cloud computer statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatuses")]
        [Validation(Required=false)]
        public List<string> DesktopStatuses { get; set; }

        /// <summary>
        /// <para>Specifies whether authorized users exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAuthUser")]
        [Validation(Required=false)]
        public bool? HasAuthUser { get; set; }

        /// <summary>
        /// <para>Specifies whether a risk exists. Used to filter cloud computers with or without risks. This parameter takes effect only when IncludeRiskInfo is set to true.</para>
        /// <para>Set to true to return only records with risks. Set to false to return only records without risks. If not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public bool? HasRisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to query and return risk information. Default value: false. When set to true, the response includes the RiskInfo field, and the HasRisk filter condition takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRiskInfo")]
        [Validation(Required=false)]
        public bool? IncludeRiskInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Hibernated</para>
        /// </summary>
        [NameInMap("ManagementStatus")]
        [Validation(Required=false)]
        public string ManagementStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether the model is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModelConfigure")]
        [Validation(Required=false)]
        public bool? ModelConfigure { get; set; }

        /// <summary>
        /// <para>The model group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Values 0 and 1 return the same result.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs (underlying real resource IDs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-xxxxx</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

    }

}
