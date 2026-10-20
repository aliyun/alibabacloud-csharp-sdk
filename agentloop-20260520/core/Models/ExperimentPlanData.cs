// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExperimentPlanData : TeaModel {
        /// <summary>
        /// <para>The creation time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767225600000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the associated dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-123456</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer service Q&amp;A offline evaluation plan</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of experiment executions under this plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("experimentCount")]
        [Validation(Required=false)]
        public int? ExperimentCount { get; set; }

        /// <summary>
        /// <para>The experiment type: offline (offline experiment) or online (online experiment).</para>
        /// 
        /// <b>Example:</b>
        /// <para>offline</para>
        /// </summary>
        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// <para>The name of the associated data processing pipeline. This field is empty if no pipeline is associated. After a pipeline is associated, when an experiment under this plan completes and writes experiment results to the Logstore, the system filters by the traceId of the current experiment trace and calls PreviewPipeline to write the results processed by the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace-process-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The experiment plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-plan-e95bff54685a4ae29ff3a834c1008a71</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The experiment plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-eval</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The custom query SQL clause in dataset-partial mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level &gt; 2</para>
        /// </summary>
        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>The status: pending, running, or stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767229200000</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
