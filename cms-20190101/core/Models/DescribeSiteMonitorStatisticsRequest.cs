// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The metric name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Availability</description></item>
        /// <item><description>ErrorRate</description></item>
        /// <item><description>ResponseTime</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Unit: milliseconds. The default value is 1 hour ahead of the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1576142850527</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the site monitoring task.</para>
        /// <para>For more information about how to obtain the ID of a site monitoring task, see <a href="https://help.aliyun.com/document_detail/115052.html">DescribeSiteMonitorList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef4cdc8b-9dc7-43e7-810e-f950e56c****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The statistical period.</para>
        /// <para>Unit: minutes. Default value: 1440 (one day). Maximum value: 43200 (30 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
