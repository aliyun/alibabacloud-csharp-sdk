// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CostQueryTrendDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>total_amount</para>
        /// </summary>
        [NameInMap("defaultMetric")]
        [Validation(Required=false)]
        public string DefaultMetric { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hourly</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("metrics")]
        [Validation(Required=false)]
        public List<MetricDefRespDTO> Metrics { get; set; }

        [NameInMap("points")]
        [Validation(Required=false)]
        public List<TrendPointDTO> Points { get; set; }

    }

}
