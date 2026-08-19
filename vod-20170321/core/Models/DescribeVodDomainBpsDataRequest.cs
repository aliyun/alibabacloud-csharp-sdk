// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name to query.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the pooled data of all accelerated domain names is returned by default.</description></item>
        /// <item><description>Batch queries are supported. Separate multiple domain names with commas (,). You can specify up to 500 domain names at a time.</description></item>
        /// <item><description>You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>, and choose <b>Configuration Management &gt; CDN Configuration &gt; Domain Names</b> in the left-side navigation pane to view the accelerated domain names that you have added to ApsaraVideo VOD. You can also invoke the <a href="~~DescribeVodUserDomains~~">DescribeVodUserDomains</a> operation to query the list of accelerated domain names.</description></item>
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
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data. Unit: seconds. Valid values: <b>300</b>, <b>3600</b>, and <b>86400</b>. If you do not specify this parameter or specify an unsupported value, the default value is used. The supported time granularity varies based on the time span specified by <c>StartTime</c> and <c>EndTime</c>:</para>
        /// <list type="bullet">
        /// <item><description>Less than 3 days (excluding exactly 3 days): <b>300</b> (default), <b>3600</b>, and <b>86400</b>.</description></item>
        /// <item><description>3 to 31 days (excluding exactly 31 days): <b>3600</b> (default) and <b>86400</b>.</description></item>
        /// <item><description>31 days or more: <b>86400</b> (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP) in English. If you do not specify this parameter, data of all ISPs is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region in English. If you do not specify this parameter, data of all regions is queried by default. Currently, only the Shanghai region is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T13:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
