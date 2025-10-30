// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAggTaskGroupStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Summary of the aggregation task group configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a54136014dc386a92c83a6ef1e97ff22</para>
        /// </summary>
        [NameInMap("aggTaskGroupConfigHash")]
        [Validation(Required=false)]
        public string AggTaskGroupConfigHash { get; set; }

        /// <summary>
        /// <para>Aggregation task group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aggTaskGroup-xxx</para>
        /// </summary>
        [NameInMap("aggTaskGroupId")]
        [Validation(Required=false)]
        public string AggTaskGroupId { get; set; }

        /// <summary>
        /// <para>Aggregation task group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pipeline-aggtask-group</para>
        /// </summary>
        [NameInMap("aggTaskGroupName")]
        [Validation(Required=false)]
        public string AggTaskGroupName { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Source Prometheus instance ID of the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxx</para>
        /// </summary>
        [NameInMap("sourcePrometheusId")]
        [Validation(Required=false)]
        public string SourcePrometheusId { get; set; }

        /// <summary>
        /// <para>The current status of the aggregated task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
