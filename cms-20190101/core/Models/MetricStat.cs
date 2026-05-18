// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class MetricStat : TeaModel {
        /// <summary>
        /// <para>The additional information about the monitored object (instance).</para>
        /// </summary>
        [NameInMap("Associated")]
        [Validation(Required=false)]
        public Dictionary<string, string> Associated { get; set; }

        /// <summary>
        /// <para>The dimension information that is used to identify the monitored object (instance).</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// <para>The recorded time of the monitoring data. Unit: milliseconds. For non-raw data (aggregated data), the value of LogTime is NULL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683686550073</para>
        /// </summary>
        [NameInMap("LogTime")]
        [Validation(Required=false)]
        public long? LogTime { get; set; }

        /// <summary>
        /// <para>The measured value of the metric. The parameter contains multiple values by default.</para>
        /// </summary>
        [NameInMap("Measurements")]
        [Validation(Required=false)]
        public Dictionary<string, object> Measurements { get; set; }

        /// <summary>
        /// <para>The metric that is used to monitor the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_idle</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The time interval based on which the metric value is measured.</para>
        /// <para>Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The timestamp of the monitoring data. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641454680000</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
