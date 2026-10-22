// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMemorySessionMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. You must specify at least one of AgentId and UserId. The length is limited to 1 to 128 UTF-8 bytes. The forward slash (/) and asterisk (*) are not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-001</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Default value: 200. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The session ID. The length is limited to 1 to 128 UTF-8 bytes. The forward slash (/) and asterisk (*) are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-001</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user ID. You must specify at least one of UserId and AgentId. The length is limited to 1 to 128 UTF-8 bytes. The forward slash (/) and asterisk (*) are not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
