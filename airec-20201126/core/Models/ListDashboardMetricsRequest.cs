// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListDashboardMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The statistical results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586673466</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("metricQuery")]
        [Validation(Required=false)]
        public string MetricQuery { get; set; }

        /// <summary>
        /// <para>The statistical results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The details about the metric.</para>
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("metricView")]
        [Validation(Required=false)]
        public string MetricView { get; set; }

        /// <summary>
        /// <para>USERACTIONPV_COUNT</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586673466</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
