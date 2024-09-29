// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateMetricDropRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Prometheus instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3ca36c8e2693403d85c0d9f8bb1d7b6c</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of discarded metrics. Specify one metric name in each line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiserver_request_duration_seconds_bucket
        /// etcd_request_duration_seconds_bucket
        /// apiserver_request_total
        /// container_tasks_state</para>
        /// </summary>
        [NameInMap("MetricDrop")]
        [Validation(Required=false)]
        public string MetricDrop { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
