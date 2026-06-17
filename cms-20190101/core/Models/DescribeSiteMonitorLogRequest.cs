// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorLogRequest : TeaModel {
        /// <summary>
        /// <para>The type of the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chrome</para>
        /// </summary>
        [NameInMap("Browser")]
        [Validation(Required=false)]
        public string Browser { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("BrowserInfo")]
        [Validation(Required=false)]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// <para>The city ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>546</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The type of the device. This parameter specifies the screen size for impersonation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>laptop</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>UTC format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Use UNIX timestamps to prevent time zone-related issues.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1638422475687</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter expression for detection results.</para>
        /// <para>Simple expressions are supported. For example, you can use the <c>TotalTime&gt;100</c> expression to query the detection data whose total response time exceeds 100 milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TotalTime&gt;100</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The carrier ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>465</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Valid values: 1 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The metric.</para>
        /// <para>Only the <c>ProbeLog</c> metric is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProbeLog</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>If the response is truncated, use the <c>NextToken</c> parameter to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>UTC format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time and end time follow the (StartTime, EndTime] pattern. The value of StartTime cannot be the same as or later than the value of EndTime.<br> - Use UNIX timestamps to prevent time zone-related issues.<br></description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1638422474389</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the detection task. You can specify multiple task IDs. Separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afa5c3ce-f944-4363-9edb-ce919a29****</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
