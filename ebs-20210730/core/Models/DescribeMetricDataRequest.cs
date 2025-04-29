// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>Aggregation method in time dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUM</description></item>
        /// <item><description>COUNT</description></item>
        /// <item><description>AVG</description></item>
        /// <item><description>MAX</description></item>
        /// <item><description>MIN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUM</para>
        /// </summary>
        [NameInMap("AggreOps")]
        [Validation(Required=false)]
        public string AggreOps { get; set; }

        [NameInMap("AggreOverLineOps")]
        [Validation(Required=false)]
        public string AggreOverLineOps { get; set; }

        /// <summary>
        /// <para>The dimension map in the JSON format. A dimension is a key-value pair. Valid dimension key: diskId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;diskId&quot;:[&quot;d-bp14xxxx&quot;,&quot;d-bp11xxxx&quot;]}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The specified time must be later than the current time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disk_bps_percent</description></item>
        /// <item><description>disk_iops_percent</description></item>
        /// <item><description>disk_read_block_size</description></item>
        /// <item><description>disk_read_bps</description></item>
        /// <item><description>disk_read_iops</description></item>
        /// <item><description>disk_read_latency</description></item>
        /// <item><description>disk_write_block_size</description></item>
        /// <item><description>disk_write_bps</description></item>
        /// <item><description>disk_write_iops</description></item>
        /// <item><description>disk_write_latency</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk_bps_percent</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The interval at which metric data is collected. Unit: seconds. Default value: 60. Valid values: 60, 300, 600, and 3600, which support queries for time ranges of up to 2 hours, 2 hours, 1 day, and 7 days, respectively. For example, if you set Period to 60, the end time is less than 2 hours from the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. You can specify a point in time that is up to one year apart from the current time. If StartTime and EndTime are both unspecified, the monitoring metric data of the last Period value is queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T01:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
