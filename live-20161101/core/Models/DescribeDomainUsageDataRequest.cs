// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeDomainUsageDataRequest : TeaModel {
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
        /// <item><description><b>all</b>: all regions</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value CN is used. Alibaba Cloud supports the following countries and regions outside the Chinese mainland: - Asia Pacific 1: Hong Kong (China), Macao (China), Taiwan (China), Japan, and Southeast Asia excluding Vietnam and Indonesia. - Asia Pacific 2: Indonesia, South Korea, and Vietnam. - Asia Pacific 3: Australia and New Zealand. - North America: US and Canada. - South America: Brazil. Europe: Ukraine, UK, France, Netherlands, Spain, Italy, Sweden, and Germany. - Middle East and Africa: South Africa, Oman, UAE, and Kuwait.</para>
        /// </remarks>
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
        /// <item><description><b>http</b>: HTTP</description></item>
        /// <item><description><b>https</b>: HTTPS</description></item>
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
        /// <para>The domain name.</para>
        /// <list type="bullet">
        /// <item><description>You can query one or more domain names. If you specify multiple domain names, separate them with commas (,).</description></item>
        /// <item><description>If you leave this parameter empty, the data of all domain names within your Alibaba Cloud account is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>The end time must be later than the start time. The maximum time range that you can specify is <b>31</b> days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The category of the resource usage data to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bps</b>: streaming bandwidth</description></item>
        /// <item><description><b>traf</b>: streaming traffic</description></item>
        /// <item><description><b>req_traf</b>: stream ingest traffic if you set Type to push, or stream relay traffic if you set Type to push_proxy</description></item>
        /// <item><description><b>req_bps</b>: stream ingest bandwidth if you set Type to push, or stream relay bandwidth if you set Type to push_proxy</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traf</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The time interval between the data entries to return. Unit: seconds. Valid values: <b>300</b> (5 minutes), <b>3600</b> (1 hour), and <b>86400</b> (1 day).</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of the resource usage data to query.</para>
        /// <para>Valid values if you set <b>Field</b> to <b>bps</b> or <b>traf</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>rts</b>: bandwidth or traffic for Real-Time Streaming (RTS)</description></item>
        /// <item><description><b>quic</b>: bandwidth or traffic for QUIC</description></item>
        /// <item><description><b>all</b>: all bandwidth or traffic</description></item>
        /// </list>
        /// <para>Valid values if you set <b>Field</b> to <b>req_traf</b> or <b>req_bps</b>:</para>
        /// <list type="bullet">
        /// <item><description><b>push</b>: stream ingest bandwidth or traffic</description></item>
        /// <item><description><b>push_proxy</b>: stream relay bandwidth or traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
