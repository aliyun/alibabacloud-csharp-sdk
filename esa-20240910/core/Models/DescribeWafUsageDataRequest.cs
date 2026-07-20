// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeWafUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for the query data, in seconds.</para>
        /// <para>The valid values vary based on the time range specified by <b>StartTime</b> and <b>EndTime</b>:</para>
        /// <list type="bullet">
        /// <item><description><para>Less than 3 days: Valid values are <b>300</b>, <b>3600</b>, and <b>86400</b>. Default value: <b>300</b>.</para>
        /// </description></item>
        /// <item><description><para>3 to 31 days (exclusive of 31 days): Valid values are <b>3600</b> and <b>86400</b>. Default value: <b>3600</b>.</para>
        /// </description></item>
        /// <item><description><para>31 days or more: The only valid value is <b>86400</b>. Default value: <b>86400</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The domain record name. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the domain record name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The grouping key. You can set this parameter to <b>domain</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: groups the data by domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
