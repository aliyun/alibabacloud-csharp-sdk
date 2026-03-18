// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryQuotaMetricRequest : TeaModel {
        /// <summary>
        /// <para>The fixed interval in seconds. If you leave this parameter empty, the system uses an automatic interval policy.</para>
        /// <list type="bullet">
        /// <item><description><para>Automatic interval policy: The interval is 60 seconds for a time range within 6 hours, 300 seconds for a time range within 24 hours, 900 seconds for a time range within 72 hours, and 1,800 seconds for a time range longer than 72 hours.</para>
        /// </description></item>
        /// <item><description><para>Specified interval: Valid values are 60, 300, and 900. The query time range must be within 72 hours.</para>
        /// </description></item>
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
        /// <para>The end of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The aggregation strategy for the data. The default value is max. Valid values: max and avg.</para>
        /// <para>Data is collected at one-minute intervals. If you query a long time range, the system may use an interval longer than one minute and aggregate the data. This parameter specifies how the data is aggregated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
