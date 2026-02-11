// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimesRequest : TeaModel {
        /// <summary>
        /// <para>根据智能体运行时名称进行模糊匹配过滤</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>用于服务发现的资源组标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123456</para>
        /// </summary>
        [NameInMap("discoveryResourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiscoveryResourceGroupId { get; set; }

        /// <summary>
        /// <para>当前页码，从1开始计数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页返回的记录数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>查询模式，支持精确查询和模糊查询</para>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("searchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>根据状态进行过滤，多个状态用逗号分隔，支持精确匹配</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY,CREATING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>根据工作空间ID进行过滤，用于资源隔离和权限管理</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
