// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentSpecsRequest : TeaModel {
        /// <summary>
        /// <para>The AgentSpec name used as a search keyword. Use this parameter together with the search parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-worker</para>
        /// </summary>
        [NameInMap("agentSpecName")]
        [Validation(Required=false)]
        public string AgentSpecName { get; set; }

        /// <summary>
        /// <para>The business tag used for fuzzy filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai</para>
        /// </summary>
        [NameInMap("bizTag")]
        [Validation(Required=false)]
        public string BizTag { get; set; }

        /// <summary>
        /// <para>The field by which to sort results. Set this parameter to download_count to sort by download count. By default, results are sorted by update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download_count</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The owner used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The visibility scope used to filter results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC</description></item>
        /// <item><description>PRIVATE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accurate: exact match.</description></item>
        /// <item><description>blur: fuzzy match.</description></item>
        /// </list>
        /// <para>Default value: blur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>blur</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the Skills and McpServers lists. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withCapabilities")]
        [Validation(Required=false)]
        public bool? WithCapabilities { get; set; }

    }

}
