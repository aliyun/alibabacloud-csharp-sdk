// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCMetricListRequest : TeaModel {
        /// <summary>
        /// <para>Queries the monitoring data of specified resources in batches for Custom for SQL Server.
        /// Format: a collection of <c>key:value</c> pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;rc-l9hv3rv74ql7oa******&quot;},{&quot;instanceId&quot;:&quot;rc-b532l1uj8n6sex******&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <c>2024-08-06 10:15:00</c> format. The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06 10:15:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of records per page for paging query.</para>
        /// <para>Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The <a href="https://cms.console.aliyun.com/metric-meta/acs_ecs_dashboard/ecs">monitoring metric</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPUUtilization</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6178f1825f9fb76ce0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>60 (default)</description></item>
        /// <item><description>An integer multiple of 60</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <c>2024-08-06 10:05:00</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06 10:05:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
