// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of pipelines to return in the current request. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the nextToken value from the previous response to retrieve the next page of results. Do not specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the pipeline. Supports exact matching. If not specified, the results are not filtered by pipeline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The schedule status. Valid values: None (no schedule), Active (active), Paused (paused), and Terminated (terminated). If not specified, the results are not filtered by schedule status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// <para>The schedule type. Valid values: RunOnce (single execution), Scheduled (periodic scheduling), and Continuous (continuous execution driven by trace source signals). If not specified, the results are not filtered by schedule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunOnce</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The name of the output dataset. Supports exact matching and applies to standard sinks, conditional branch sinks, and default sinks. If not specified, the results are not filtered by sink name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-dataset</para>
        /// </summary>
        [NameInMap("sinkName")]
        [Validation(Required=false)]
        public string SinkName { get; set; }

    }

}
