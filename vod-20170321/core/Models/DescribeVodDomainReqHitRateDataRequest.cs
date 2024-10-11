// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainReqHitRateDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the merged data of all your accelerated domain names is returned.</description></item>
        /// <item><description>You can specify a maximum of 500 accelerated domain names. Separate multiple domain names with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity. Unit: seconds. Valid values: <b>300</b>, <b>3600</b>, and <b>86400</b>. If you leave this parameter empty or specify an invalid value, the default value is used. The supported time granularity varies based on the time range specified by <c>EndTime</c> and <c>StartTime</c>. The following content describes the supported time granularity.</para>
        /// <list type="bullet">
        /// <item><description>Time range per query &lt; 3 days: <b>300</b> (default), <b>3600</b>, and <b>86400</b></description></item>
        /// <item><description>3 days ≤ Time range per query &lt; 31 days: <b>3600</b> (default) and <b>86400</b></description></item>
        /// <item><description>31 days ≤ Time range per query ≤ 90 days: <b>86400</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
