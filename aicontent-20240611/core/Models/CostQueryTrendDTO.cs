// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CostQueryTrendDTO : TeaModel {
        /// <summary>
        /// <para>The default metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total_amount</para>
        /// </summary>
        [NameInMap("defaultMetric")]
        [Validation(Required=false)]
        public string DefaultMetric { get; set; }

        /// <summary>
        /// <para>The granularity of the data. Valid values are <c>hourly</c> and <c>daily</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hourly</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>A list of metric definitions.</para>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public List<MetricDefRespDTO> Metrics { get; set; }

        /// <summary>
        /// <para>A list of data points for the trend.</para>
        /// </summary>
        [NameInMap("points")]
        [Validation(Required=false)]
        public List<TrendPointDTO> Points { get; set; }

    }

}
