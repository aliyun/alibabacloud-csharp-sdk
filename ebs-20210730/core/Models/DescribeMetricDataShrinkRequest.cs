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
        /// <para>Dimension map, in JSON format, representing the dimensions being queried. The currently available keys are:</para>
        /// <list type="bullet">
        /// <item><description>DiskId: Cloud disk name, e.g., d-xxx.</description></item>
        /// <item><description>DeviceType: Type of cloud disk, system indicates system disk, data indicates data disk.</description></item>
        /// <item><description>DeviceCategory: Category of cloud disk, e.g., cloud_essd.</description></item>
        /// <item><description>EcsInstanceId: Name of the ECS instance where the disk is located, e.g., i-xxx.</description></item>
        /// </list>
        /// <para>The returned results are the intersection of all dimension filter conditions.</para>
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
        /// <para>The interval for obtaining metric data. Unit: seconds. The default value is 5 seconds. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description>5: 5s precision query, can query up to 12 hours of data</description></item>
        /// <item><description>10: 10s precision query, can query up to 24 hours of data</description></item>
        /// <item><description>60: 60s precision query, can query up to 7 days of data</description></item>
        /// <item><description>3600: 3600s precision query, can query up to 30 days of data</description></item>
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
        /// <para>The start time point for obtaining metric data. The earliest selectable time is one year before the current moment. When both StartTime and EndTime parameters are empty, it defaults to querying the most recent period\&quot;s monitoring metrics. Represented according to the ISO 8601 standard, using UTC +0 time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-21T01:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
