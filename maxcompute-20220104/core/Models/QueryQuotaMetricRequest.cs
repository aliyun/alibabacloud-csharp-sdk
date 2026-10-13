// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryQuotaMetricRequest : TeaModel {
        /// <summary>
        /// <para>The fixed interval in seconds. By default, this parameter is empty, which indicates that the adaptive interval policy of the system is used.</para>
        /// <list type="bullet">
        /// <item><description>Adaptive interval policy: The interval is 60 seconds if the query time range is within 6 hours, 300 seconds if within 24 hours, 900 seconds if within 72 hours, and 1800 seconds if exceeding 72 hours.</description></item>
        /// <item><description>Specified interval: Only 60, 300, and 900 are supported. The query time range must be within 72 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The nickname of the level-1 quota. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os_sns_p</para>
        /// </summary>
        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("subMetric")]
        [Validation(Required=false)]
        public string SubMetric { get; set; }

        /// <summary>
        /// <para>The nickname of the level-2 quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os_sns</para>
        /// </summary>
        [NameInMap("subQuotaNickname")]
        [Validation(Required=false)]
        public string SubQuotaNickname { get; set; }

        /// <summary>
        /// <para>The end time of the query time range. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query time range. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The data aggregation policy. Default value: max. Valid values: max and avg.</para>
        /// <para>Data is collected every 1 minute. If the query time range is large, the adaptive step size for data display exceeds 1 minute, and the metrics are aggregated. This parameter specifies the data aggregation logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
