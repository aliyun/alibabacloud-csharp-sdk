// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1551581437000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of data points to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The metric name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Availability</description></item>
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

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49f7b317-7645-4cc9-94fd-ea42e5220930ea42e5220930ea42e522****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period. The value is an integral multiple of 60. Unit: seconds.</para>
        /// <remarks>
        /// <para> The default value equals the minimum interval at which detection requests are sent to the monitored address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1551579637000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49f7b317-7645-4cc9-94fd-ea42e522****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the monitored object whose monitoring data is to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>metric</description></item>
        /// <item><description>event</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>metric</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
