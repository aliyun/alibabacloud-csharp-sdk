// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelTemplatesShrinkRequest : TeaModel {
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
        /// <para>The list of Agent platforms. Supports COMMON. If specified together with AgentPlatform, AgentPlatform takes precedence and this list is ignored. If neither platform filter is specified, the default value is ENTERPRISE. To query Common model groups, explicitly include COMMON. If filtering by Provider at the same time, set the value to Common.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatformList")]
        [Validation(Required=false)]
        public List<string> AgentPlatformList { get; set; }

        /// <summary>
        /// <para>The Agent provider name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The list of Agent providers. Supports Common. If specified together with AgentProvider, AgentProvider takes precedence and this list is ignored. To query Common model groups, explicitly include COMMON in the platform filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProviderList")]
        [Validation(Required=false)]
        public List<string> AgentProviderList { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>Specifies whether models are configured in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasModel")]
        [Validation(Required=false)]
        public bool? HasModel { get; set; }

        /// <summary>
        /// <para>The list of template group IDs used for filtering.</para>
        /// </summary>
        [NameInMap("ModelTemplateIdList")]
        [Validation(Required=false)]
        public string ModelTemplateIdListShrink { get; set; }

        /// <summary>
        /// <para>The model group name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coding-openai</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The authorization scope filter. Valid values: ALL_USER, USER_MIXED, and RESOURCE_MIXED (strictly uppercase. Case variants and unknown values return InvalidParameter). If not specified, no filtering is applied. Unlike the create/update operations, the filter scenario allows RESOURCE_MIXED (to filter non-Common model groups).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_USER</para>
        /// </summary>
        [NameInMap("RefScope")]
        [Validation(Required=false)]
        public string RefScope { get; set; }

        /// <summary>
        /// <para>The template source filter. Valid values: User (tenant-created, default if not specified) and System (system preset).</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
