// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The method for aggregating data over time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUM_OVER_TIME</description></item>
        /// <item><description>COUNT_OVER_TIME</description></item>
        /// <item><description>AVG_OVER_TIME</description></item>
        /// <item><description>MAX_OVER_TIME</description></item>
        /// <item><description>MIN_OVER_TIME</description></item>
        /// <item><description>SUM_OVER_TIME_LCRO: The sum of values in a left-closed, right-open interval.</description></item>
        /// <item><description>AVG_OVER_TIME_LCRO: The average of values in a left-closed, right-open interval.</description></item>
        /// <item><description>SUM_OVER_TIME_LORC: The sum of values in a left-open, right-closed interval.</description></item>
        /// <item><description>AVG_OVER_TIME_LORC: The average of values in a left-open, right-closed interval.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVG_OVER_TIME</para>
        /// </summary>
        [NameInMap("AggreOps")]
        [Validation(Required=false)]
        public string AggreOps { get; set; }

        /// <summary>
        /// <para>The method for aggregating data across different lines. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NON: No aggregation is performed.</description></item>
        /// <item><description>SUM: The sum of values.</description></item>
        /// <item><description>AVG: The average of values.</description></item>
        /// <item><description>COUNT: The number of values.</description></item>
        /// <item><description>MAX: The maximum value.</description></item>
        /// <item><description>MIN: The minimum value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NON</para>
        /// </summary>
        [NameInMap("AggreOverLineOps")]
        [Validation(Required=false)]
        public string AggreOverLineOps { get; set; }

        /// <summary>
        /// <para>A map of dimensions in the JSON format. The map specifies the dimensions to query. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description>DiskId: The disk name, such as d-xxx.</description></item>
        /// <item><description>DeviceType: The disk category. \<c>system\\</c> indicates a system disk and \<c>data\\</c> indicates a data disk.</description></item>
        /// <item><description>DeviceCategory: The disk type, such as cloud_essd.</description></item>
        /// <item><description>EcsInstanceId: The name of the ECS instance to which the disk is attached, such as i-xxx.</description></item>
        /// <item><description>Azone: The zone, such as cn-hangzhou-a.</description></item>
        /// </list>
        /// <para>The returned results are the intersection of all specified dimension-based filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DiskId&quot;:[&quot;d-bp14xxxx&quot;,&quot;d-bp11xxxx&quot;], &quot;DeviceCategory&quot;: [&quot;cloud_essd&quot;]}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query metric data. The time cannot be later than the current time. The time must be in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A list of fields for grouping and aggregation.</para>
        /// </summary>
        [NameInMap("GroupByLabels")]
        [Validation(Required=false)]
        public string GroupByLabelsShrink { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disk_bps_percent</description></item>
        /// <item><description>disk_iops_percent</description></item>
        /// <item><description>disk_read_block_size</description></item>
        /// <item><description>disk_read_bps</description></item>
        /// <item><description>disk_read_iops</description></item>
        /// <item><description>disk_write_block_size</description></item>
        /// <item><description>disk_write_bps</description></item>
        /// <item><description>disk_write_iops</description></item>
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
        /// <para>The interval at which to query metric data. Unit: seconds. The default value is 5. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: 5-second precision. You can query data within a 12-hour time range.</description></item>
        /// <item><description>10: 10-second precision. You can query data within a 24-hour time range.</description></item>
        /// <item><description>60: 60-second precision. You can query data within a 7-day time range.</description></item>
        /// <item><description>300: 300-second precision. You can query data within a 30-day time range.</description></item>
        /// <item><description>600: 600-second precision. You can query data within a 30-day time range.</description></item>
        /// <item><description>3600: 3600-second precision. You can query data within a 30-day time range.</description></item>
        /// </list>
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
        /// <para>The beginning of the time range to query metric data. The start time can be up to 30 days before the current time. If you leave both the StartTime and EndTime parameters empty, the system queries the metrics for the most recent period. The time must be in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T01:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
