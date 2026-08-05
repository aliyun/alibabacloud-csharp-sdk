// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The region code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN</b>: the Chinese mainland.</description></item>
        /// <item><description><b>OverSeas</b>: outside the Chinese mainland.</description></item>
        /// <item><description><b>AP1</b>: Asia-Pacific 1.</description></item>
        /// <item><description><b>AP2</b>: Asia-Pacific 2.</description></item>
        /// <item><description><b>AP3</b>: Asia-Pacific 3.</description></item>
        /// <item><description><b>NA</b>: North America.</description></item>
        /// <item><description><b>SA</b>: South America.</description></item>
        /// <item><description><b>EU</b>: Europe.</description></item>
        /// <item><description><b>MEAA</b>: Middle East and Africa.</description></item>
        /// <item><description><b>all</b>: all regions.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is the Chinese mainland. Regions outside the Chinese mainland: - Asia-Pacific 1: Hong Kong (China), Macao (China), Taiwan (China), Japan, and Southeast Asian countries except Vietnam and Indonesia. - Asia-Pacific 2: Indonesia, South Korea, and Vietnam. - Asia-Pacific 3: Australia and New Zealand. North America: the United States and Canada. - South America: Brazil. - Europe: Ukraine, the United Kingdom, France, the Netherlands, Spain, Italy, Sweden, and Germany. - Middle East and Africa: South Africa, Oman, the United Arab Emirates, and Kuwait.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The protocol of the data to retrieve. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>http</b>: HTTP.</para>
        /// </description></item>
        /// <item><description><para><b>https</b>: HTTPS.</para>
        /// </description></item>
        /// <item><description><para><b>quic</b>: QUIC.</para>
        /// </description></item>
        /// <item><description><para><b>all</b> (default): all of the preceding protocols.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DataProtocol")]
        [Validation(Required=false)]
        public string DataProtocol { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <list type="bullet">
        /// <item><description><para>You can specify a single domain name or multiple domain names. Separate multiple domain names with commas (,).</para>
        /// </description></item>
        /// <item><description><para>If this parameter is empty, the merged data of all streaming domains is returned by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>The end time must be later than the start time, and the difference between the end time and the start time cannot exceed <b>31</b> days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data type of the usage data to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>bps</b>: playback bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>traf</b>: traffic.</para>
        /// </description></item>
        /// <item><description><para><b>req_traf</b>: when Type is set to push, this indicates stream ingest traffic. When Type is set to push_proxy, this indicates relay traffic.</para>
        /// </description></item>
        /// <item><description><para><b>req_bps</b>: when Type is set to push, this indicates stream ingest bandwidth. When Type is set to push_proxy, this indicates relay bandwidth.</para>
        /// </description></item>
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
        /// <para>Forces retrieval of data at the specified time granularity, in seconds. Valid values: <b>300</b> (5 minutes), <b>3600</b> (1 hour), and <b>86400</b> (1 day).</para>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of usage data to retrieve.</para>
        /// <para>When <b>Field</b> is set to <b>bps</b> or <b>traf</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rts</b>: RTS bandwidth or traffic.</description></item>
        /// <item><description><b>quic</b>: QUIC bandwidth or traffic.</description></item>
        /// </list>
        /// <para>When <b>Field</b> is set to <b>req_traf</b> or <b>req_bps</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>push</b>: stream ingest bandwidth or traffic.</description></item>
        /// <item><description><b>push_proxy</b>: relay bandwidth or traffic.</description></item>
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
