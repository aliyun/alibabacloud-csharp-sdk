// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentMcpRequest : TeaModel {
        /// <summary>
        /// <para>A compatible pagination parameter. The actual number of records per page is controlled by PageSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatible pagination token. The actual page sequence is controlled by PageNumber.</para>
        /// 
        /// <b>Example:</b>
        /// <para>page-2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 1 to 500. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only MCP Servers that are enabled and in the ready state. Default value: false.</para>
        /// </summary>
        [NameInMap("ReadyOnly")]
        [Validation(Required=false)]
        public bool? ReadyOnly { get; set; }

        /// <summary>
        /// <para>The keyword for name search. The server performs a fuzzy match against MCP Server names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The MCP Server type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: system MCP.</description></item>
        /// <item><description>customer: custom MCP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The Data Agent workspace ID. The caller must have at least MEMBER permissions on this workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atvx***xmz</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
