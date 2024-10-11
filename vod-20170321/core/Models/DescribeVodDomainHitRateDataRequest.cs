// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainHitRateDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the merged data of all your accelerated domain names is returned.</description></item>
        /// <item><description>You can specify multiple domain names and separate them with commas (,). You can specify a maximum of 500 domain names in each call.</description></item>
        /// <item><description>To obtain the accelerated domain name, perform the following steps: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management &gt; CDN Configuration &gt; Domain Names</b>. On the Domain Names page, view the accelerated domain names. Alternatively, you can call the <a href="~~DescribeVodUserDomains~~">DescribeVodUserDomains</a> operation to query the accelerated domain names.</description></item>
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
        /// <para>2024-01-20T14:59:58Z</para>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-20T13:59:58Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
