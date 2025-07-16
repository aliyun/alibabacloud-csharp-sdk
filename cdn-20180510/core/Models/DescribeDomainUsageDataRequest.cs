// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The billable region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN</b> (default): inside the Chinese mainland</description></item>
        /// <item><description><b>OverSeas</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>AP1</b>: Asia Pacific 1</description></item>
        /// <item><description><b>AP2</b>: Asia Pacific 2</description></item>
        /// <item><description><b>AP3</b>: Asia Pacific 3</description></item>
        /// <item><description><b>NA</b>: North America</description></item>
        /// <item><description><b>SA</b>: South America</description></item>
        /// <item><description><b>EU</b>: Europe</description></item>
        /// <item><description><b>MEAA</b>: Middle East and Africa</description></item>
        /// <item><description><b>all</b>: all the preceding billable regions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The protocol of the data that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http:</b> HTTP</description></item>
        /// <item><description><b>https:</b> HTTPS</description></item>
        /// <item><description><b>quic</b>: QUIC</description></item>
        /// <item><description><b>all</b> (default): HTTP, HTTPS, and QUIC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DataProtocol")]
        [Validation(Required=false)]
        public string DataProtocol { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. You can specify up to 100 domain names in each request. Separate multiple domain names with commas (,).</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the usage data of all accelerated domain names in your Alibaba Cloud account is returned.</para>
        /// </remarks>
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
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is 31 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the data that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bps</b>: bandwidth</description></item>
        /// <item><description><b>traf</b>: traffic</description></item>
        /// <item><description><b>acc</b>: requests</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>acc</b>, the <b>Area</b> parameter is not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The time granularity of the data entries. Unit: seconds. Valid values: <b>300</b> (5 minutes), <b>3600</b> (1 hour), and <b>86400</b> (1 day).</para>
        /// <list type="bullet">
        /// <item><description>If <b>Interval</b> is set to <b>300</b>, you can query usage data in the last 6 months. The maximum time range per query that can be specified is 3 days.</description></item>
        /// <item><description>If <b>Interval</b> is set to <b>3600</b> or <b>86400</b>, you can query usage data of the previous year.</description></item>
        /// <item><description>If you leave the <b>Interval</b> parameter empty, the maximum time range that you can query is 1 month. If you specify a time range of 1 to 3 days, the time interval between the entries that are returned is 1 hour. If you specify a time range of at least 4 days, the time interval between the entries that are returned is 1 day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>Data is collected every 5 minutes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of content that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static</b>: static content</description></item>
        /// <item><description><b>dynamic</b>: dynamic content</description></item>
        /// <item><description><b>all</b> (default): both static and dynamic content</description></item>
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
