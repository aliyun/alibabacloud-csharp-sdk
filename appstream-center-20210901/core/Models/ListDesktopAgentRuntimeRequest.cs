// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListDesktopAgentRuntimeRequest : TeaModel {
        [NameInMap("AgentInstanceStatuses")]
        [Validation(Required=false)]
        public List<string> AgentInstanceStatuses { get; set; }

        [NameInMap("AgentInstanceVersions")]
        [Validation(Required=false)]
        public List<string> AgentInstanceVersions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        [NameInMap("AuthUsers")]
        [Validation(Required=false)]
        public List<string> AuthUsers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ChannelConfigure")]
        [Validation(Required=false)]
        public bool? ChannelConfigure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin</para>
        /// </summary>
        [NameInMap("DeploymentSource")]
        [Validation(Required=false)]
        public string DeploymentSource { get; set; }

        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        [NameInMap("DesktopNames")]
        [Validation(Required=false)]
        public List<string> DesktopNames { get; set; }

        [NameInMap("DesktopStatuses")]
        [Validation(Required=false)]
        public List<string> DesktopStatuses { get; set; }

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
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public bool? HasRisk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRiskInfo")]
        [Validation(Required=false)]
        public bool? IncludeRiskInfo { get; set; }

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
        /// <para>rg-xxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
