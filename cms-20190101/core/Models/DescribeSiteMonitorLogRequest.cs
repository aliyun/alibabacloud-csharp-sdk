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
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("BrowserInfo")]
        [Validation(Required=false)]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// <para>The identifier of the city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>546</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The device type, which indicates the simulated screen size type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>laptop</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The end time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>UTC format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Use UNIX timestamps to avoid time zone issues.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1638422475687</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter condition for detection values.</para>
        /// <para>Simple expressions are supported. For example, <c>TotalTime&gt;100</c> filters the detection data whose total response time exceeds 100 milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TotalTime&gt;100</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The identifier of the carrier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>465</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page for paging. Valid values: 1 to 1440.</para>
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
        /// <para>The pagination token. If the response is truncated, you can use <c>NextToken</c> to send another request and retrieve the remaining results.</para>
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
        /// <para>The start time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>UTC format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time and end time follow the left-open and right-closed interval pattern. The value of StartTime cannot be equal to or greater than the value of EndTime.                                                                                                                   <list type="bullet">
        /// <item><description>Use UNIX timestamps to avoid time zone issues.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The IDs of the detection tasks. Separate multiple IDs with commas (,).</para>
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
