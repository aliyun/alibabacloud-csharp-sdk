// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of pipelines to return. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the nextToken value returned in the previous response to retrieve the next page. Do not specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters pipelines by name using exact match. If this parameter is not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>Filters pipelines by schedule status. If this parameter is not specified, no filtering is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: No schedule.</description></item>
        /// <item><description>Active: Active.</description></item>
        /// <item><description>Paused: Paused.</description></item>
        /// <item><description>Terminated: Terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// <para>Filters pipelines by schedule type. If this parameter is not specified, no filtering is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunOnce: One-time execution.</description></item>
        /// <item><description>Scheduled: Periodic scheduling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunOnce</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>Filters pipelines by the exact name of the output dataset. Matches standard sinks, conditional branch sinks, and default sinks. If this parameter is not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-dataset</para>
        /// </summary>
        [NameInMap("sinkName")]
        [Validation(Required=false)]
        public string SinkName { get; set; }

    }

}
