// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListCopilotSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The Agent ID. If this parameter is not specified, all Agent sessions of the current user are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sysagent</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Default value: 50. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. Do not specify this parameter for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The scheduled task ID, which must be a positive integer. If this parameter is specified, sessionType must be omitted or set to cron.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("scheduledTaskId")]
        [Validation(Required=false)]
        public long? ScheduledTaskId { get; set; }

        /// <summary>
        /// <para>The session source. If this parameter is not specified, sessions are not filtered by source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openapi</para>
        /// </summary>
        [NameInMap("sessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

    }

}
