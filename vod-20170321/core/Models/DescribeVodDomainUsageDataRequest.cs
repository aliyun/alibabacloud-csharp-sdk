// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The region in which you want to query data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN</b>: Chinese mainland</description></item>
        /// <item><description><b>OverSeas</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. If you leave this parameter empty, the merged data of all your accelerated domain names is returned. Separate multiple accelerated domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T12:20:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the data to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bps</b>: bandwidth</description></item>
        /// <item><description><b>traf</b>: traffic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The time interval between the data entries to return. Unit: seconds. Valid values: <b>300</b> (5 minutes), <b>3600</b> (1 hour), and <b>86400</b> (1 day).</para>
        /// <list type="bullet">
        /// <item><description>If <b>Interval</b> is set to <b>300</b>, you can query usage data in the last six months. The maximum time range per query that can be specified is three days.</description></item>
        /// <item><description>If <b>Interval</b> is set to <b>3600</b> or <b>86400</b>, you can query usage data of the previous year.</description></item>
        /// <item><description>If you do not set the <b>Interval</b> parameter, the maximum time range that you can query is one month. If you specify a time range of 1 to 3 days, the time interval between the entries that are returned is 1 hour. If you specify a time range of at least 4 days, the time interval between the entries that are returned is 1 day.</description></item>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T10:20:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of content that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static</b>: static content</description></item>
        /// <item><description><b>dynamic</b>: dynamic requests</description></item>
        /// <item><description><b>all</b>: all content</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
