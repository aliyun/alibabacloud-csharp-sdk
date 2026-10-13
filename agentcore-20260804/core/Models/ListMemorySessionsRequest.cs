// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMemorySessionsRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. If this parameter is not specified, all agents are matched. The length is limited to 1 to 128 UTF-8 bytes, and the value cannot contain / or *.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-001</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Default value: 100. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The user ID. If this parameter is not specified, all users are matched. The length is limited to 1 to 128 UTF-8 bytes, and the value cannot contain / or *.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
