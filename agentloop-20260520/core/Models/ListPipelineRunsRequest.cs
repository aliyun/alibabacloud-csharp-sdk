// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelineRunsRequest : TeaModel {
        /// <summary>
        /// <para>The upper bound for filtering by trigger time (triggered_at &lt;= endTime), in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in the current request. Default value: 50. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the nextToken value from the previous response to retrieve the next page. Do not specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The lower bound for filtering by trigger time (triggered_at &gt;= startTime), in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735574400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Filters runs by status. Valid values: Pending, Running, Succeeded, Failed, and Cancelled. If you do not specify this parameter, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters runs by trigger type. Valid values: Continuous, RunOnce, and Scheduled. If you do not specify this parameter, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
