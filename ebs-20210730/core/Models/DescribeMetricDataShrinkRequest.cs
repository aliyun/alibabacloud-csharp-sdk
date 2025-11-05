// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Aggregation method over time. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description>SUM_OVER_TIME</description></item>
        /// <item><description>COUNT_OVER_TIME</description></item>
        /// <item><description>AVG_OVER_TIME</description></item>
        /// <item><description>MAX_OVER_TIME</description></item>
        /// <item><description>MIN_OVER_TIME</description></item>
        /// <item><description>SUM_OVER_TIME_LCRO: Sum over a left-closed, right-open interval</description></item>
        /// <item><description>AVG_OVER_TIME_LCRO: Average over a left-closed, right-open interval</description></item>
        /// <item><description>SUM_OVER_TIME_LORC: Sum over a left-open, right-closed interval</description></item>
        /// <item><description>AVG_OVER_TIME_LORC: Average over a left-open, right-closed interval</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVG_OVER_TIME</para>
        /// </summary>
        [NameInMap("AggreOps")]
        [Validation(Required=false)]
        public string AggreOps { get; set; }

        /// <summary>
        /// <para>Aggregation method between lines. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description>NON: No aggregation</description></item>
        /// <item><description>SUM: Sum</description></item>
        /// <item><description>AVG: Average</description></item>
        /// <item><description>COUNT: Count</description></item>
        /// <item><description>MAX: Maximum</description></item>
        /// <item><description>MIN: Minimum</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NON</para>
        /// </summary>
        [NameInMap("AggreOverLineOps")]
        [Validation(Required=false)]
        public string AggreOverLineOps { get; set; }

        /// <summary>
        /// <para>The dimension map, in the JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DiskId: the disk name. Example: d-xxx.</description></item>
        /// <item><description>DeviceType: the disk type. system indicates the system disk, and data indicates the data disk.</description></item>
        /// <item><description>DeviceCategory: the disk category. Example: cloud_essd.</description></item>
        /// <item><description>EcsInstanceId: the ECS instance name. Example: i-xxx.</description></item>
        /// <item><description>Azone: the zone, such as cn-hangzhou-a.</description></item>
        /// </list>
        /// <para>The returned result is the intersection of all dimension filtering conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DiskId&quot;:[&quot;d-bp14xxxx&quot;,&quot;d-bp11xxxx&quot;], &quot;DeviceCategory&quot;: [&quot;cloud_essd&quot;]}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end time point for obtaining metric data. It should not be later than the current moment. Represented according to the ISO 8601 standard, using UTC +0 time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of fields used for grouping and aggregation.</para>
        /// </summary>
        [NameInMap("GroupByLabels")]
        [Validation(Required=false)]
        public string GroupByLabelsShrink { get; set; }

        /// <summary>
        /// <para>Metric name. Possible values include:</para>
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
        /// <para>The granularity at which data is collected for the metric. Unit: seconds. Default value: 5. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: 5 seconds. The query time range can be up to 12 hours.</description></item>
        /// <item><description>10: 10 seconds. The query time range can be up to 24 hours.</description></item>
        /// <item><description>60: 60 seconds. The query time range can be up to 7 days.</description></item>
        /// <item><description>300: 300 seconds. The query time range can be up to 30 days.</description></item>
        /// <item><description>600: 600 seconds. The query time range can be up to 30 days.</description></item>
        /// <item><description>3600: 3,600 seconds. The query time range can be up to 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. You can specify a point in time that is up to 30 days before the current time. If both StartTime and EndTime are left empty, the monitoring metric data of the most recent statistical period is queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T01:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
