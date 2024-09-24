// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorLogRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Chrome</para>
        /// </summary>
        [NameInMap("Browser")]
        [Validation(Required=false)]
        public string Browser { get; set; }

        [NameInMap("BrowserInfo")]
        [Validation(Required=false)]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// <para>The city identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>546</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>laptop</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format</description></item>
        /// </list>
        /// <remarks>
        /// <para> We recommend that you use UNIX timestamps to prevent time zone-related issues.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1638422475687</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>You can specify a simple expression, for example, <c>TotalTime&gt;100</c>. In this case, the operation returns only the data for instant test tasks whose total response time exceeds 100 milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TotalTime&gt;100</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The carrier identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>465</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <para>Only the <c>ProbeLog</c> metric is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProbeLog</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.``</para>
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
        /// <para>The start of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970</description></item>
        /// <item><description>UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The specified time range includes the end time and excludes the start time. The start time must be earlier than the end time.\
        /// We recommend that you use UNIX timestamps to prevent time zone-related issues.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1638422474389</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The IDs of the instant test tasks. Separate multiple task IDs with commas (,).</para>
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
