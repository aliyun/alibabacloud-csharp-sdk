// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The billable region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN</b>: Chinese mainland</description></item>
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
        /// <para>Default value: <b>CN</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The protocol of the data to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>quic</b>: Quick UDP Internet Connections (QUIC)</description></item>
        /// <item><description><b>https</b>: HTTPS</description></item>
        /// <item><description><b>http</b>: HTTP</description></item>
        /// <item><description><b>all</b>: all the preceding protocols</description></item>
        /// </list>
        /// <para>Default value: <b>all</b></para>
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
        /// <para> If you do not specify this parameter, the usage data of all accelerated domain names that belong to your Alibaba Cloud account is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The maximum time range that can be queried is 31 days.</para>
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
        /// <para>The type of data that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bps</b>: bandwidth</description></item>
        /// <item><description><b>traf</b>: traffic</description></item>
        /// <item><description><b>acc</b>: requests</description></item>
        /// </list>
        /// <remarks>
        /// <para> <b>acc</b> does not support the <b>Area</b> parameter.</para>
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
        /// <para>The time interval between the data entries to return. Unit: seconds.</para>
        /// <para>The time interval varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see <b>Usage notes</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The minimum time granularity at which the data is queried is 5 minutes.</para>
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
        /// <para>The type of the requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static</b>: static requests</description></item>
        /// <item><description><b>dynamic</b>: dynamic requests</description></item>
        /// <item><description><b>all</b>: all requests</description></item>
        /// </list>
        /// <para>Default value: <b>all</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>dynamic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
