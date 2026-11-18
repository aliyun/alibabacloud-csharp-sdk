// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name to query.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the pooled data of all accelerated domain names is returned by default.</description></item>
        /// <item><description>Supports batch queries. Separate multiple domain names with commas (,). You can query up to 500 domain names at a time.</description></item>
        /// <item><description>You can logon to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management &gt; Distribution Acceleration Configuration &gt; Domain Names</b> in the left-side navigation pane to view the accelerated domain names added to ApsaraVideo VOD. Alternatively, you can invoke the <a href="~~DescribeVodUserDomains~~">DescribeVodUserDomains</a> API operation to query the list of accelerated domain names.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the data to retrieve. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-26T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data to query. Unit: seconds. Valid values: <b>300</b>, <b>3600</b>, and <b>86400</b>. If you do not specify this parameter or specify an unsupported value, the default value is used. Based on the time span specified by StartTime and EndTime, the supported time granularities are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Less than 3 days: <b>300</b> (default), <b>3600</b>, and <b>86400</b>.</description></item>
        /// <item><description>3 to 31 days (excluding 31 days): <b>3600</b> (default) and <b>86400</b>.</description></item>
        /// <item><description>More than 31 days: <b>86400</b> (default).</description></item>
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
        /// <para>The start time of the data to retrieve. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-25T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
