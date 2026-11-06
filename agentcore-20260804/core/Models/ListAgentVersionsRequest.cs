// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentVersionsRequest : TeaModel {
        /// <summary>
        /// <para>单页最大记录数，取值范围 1 至 100，默认 20。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>查询下一页时传入上一次 ListAgentVersions 响应返回的 nextToken；首次查询不传。</para>
        /// 
        /// <b>Example:</b>
        /// <para>YWdlbnQtdmVyc2lvbnM6MjA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
