// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListCopilotSessionMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID retained for compatibility with historical calls. This parameter can be omitted. Currently, the entire session is queried by sessionId, and this parameter does not change the query scope of historical events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sysagent</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The page size retained for compatibility with historical calls. Default value: 50. Valid values: 1 to 200. For new integrations, we recommend using maxResults. If both parameters are specified, maxResults takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The page size. Default value: 50. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. Do not specify this parameter for the first request. For subsequent requests, use the nextToken value from the previous response. Clear this value when you change the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination offset retained for compatibility with historical calls. Default value: 0. For new integrations, we recommend using nextToken. Do not specify this parameter and nextToken at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s001</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
