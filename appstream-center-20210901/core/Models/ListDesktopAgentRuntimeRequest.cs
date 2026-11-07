// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListDesktopAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>The Agent IM online status filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("AgentImOnlineStatus")]
        [Validation(Required=false)]
        public string AgentImOnlineStatus { get; set; }

        /// <summary>
        /// <para>The list of Agent instance statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("AgentInstanceStatuses")]
        [Validation(Required=false)]
        public List<string> AgentInstanceStatuses { get; set; }

        /// <summary>
        /// <para>The list of Agent instance versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw 2026.4.15</para>
        /// </summary>
        [NameInMap("AgentInstanceVersions")]
        [Validation(Required=false)]
        public List<string> AgentInstanceVersions { get; set; }

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
        /// <para>The list of Agent platforms. If both AgentPlatform and AgentPlatformList are specified, AgentPlatform takes precedence and this list is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatformList")]
        [Validation(Required=false)]
        public List<string> AgentPlatformList { get; set; }

        /// <summary>
        /// <para>The name of the Agent provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgenticComputer</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The list of Agent providers. If both AgentProvider and AgentProviderList are specified, AgentProvider takes precedence and this list is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProviderList")]
        [Validation(Required=false)]
        public List<string> AgentProviderList { get; set; }

        /// <summary>
        /// <para>The list of Agent template IDs. A match occurs only when all valid templates are assigned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-xxxxx</para>
        /// </summary>
        [NameInMap("AgentTemplateIds")]
        [Validation(Required=false)]
        public List<string> AgentTemplateIds { get; set; }

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
        /// <para>The business region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

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
        /// <para>Specifies whether a third-party channel is configured.</para>
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
        /// <para>The list of Agent runtime IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jvs-xxxxx</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The list of Agent runtime names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop001</para>
        /// </summary>
        [NameInMap("DesktopNames")]
        [Validation(Required=false)]
        public List<string> DesktopNames { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatuses")]
        [Validation(Required=false)]
        public List<string> DesktopStatuses { get; set; }

        /// <summary>
        /// <para>Specifies whether authorization is granted to an authorized user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAuthUser")]
        [Validation(Required=false)]
        public bool? HasAuthUser { get; set; }

        /// <summary>
        /// <para>Specifies whether a risk exists. This parameter is used to filter cloud desktops with or without risks and takes effect only when IncludeRiskInfo is set to true. If set to true, only records with risks are returned. If set to false, only records without risks are returned. If this parameter is not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public bool? HasRisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to query and return risk information. Default value: false. If set to true, the response includes the RiskInfo field, and the HasRisk filter takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRiskInfo")]
        [Validation(Required=false)]
        public bool? IncludeRiskInfo { get; set; }

        /// <summary>
        /// <para>The management status filter, such as Hibernated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hibernated</para>
        /// </summary>
        [NameInMap("ManagementStatus")]
        [Validation(Required=false)]
        public string ManagementStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether a model is configured.</para>
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
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-xxxx</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Entering 0 or 1 returns the same result.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs, which are the underlying actual resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-xxxxx</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

    }

}
