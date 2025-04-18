// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNatTopNRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query in milliseconds. If you do not specify <b>EndTime</b>, the point in time specified by <b>BeginTime</b> is queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239092000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query in milliseconds. The time range specified by <b>BeginTime</b> and <b>EndTime</b> cannot exceed <b>86400000</b> milliseconds (24 hours).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239093000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Query ranking statistics for a specific IP address. If you specify this parameter, you do not need to specify <b>TopN</b> or <b>OrderBy</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.156.101</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-sample***</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The metric that is used for real-time SNAT performance ranking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>InBps</b>: inbound data transfer. Unit: bit/s.</description></item>
        /// <item><description><b>OutBps</b>: outbound data transfer. Unit: bit/s.</description></item>
        /// <item><description><b>InPps</b>: inbound packet forwarding rate. Unit: packets per second.</description></item>
        /// <item><description><b>OutPps</b>: outbound packet forwarding rate. Unit: packets per second.</description></item>
        /// <item><description><b>NewSessionPerSecond</b>: new connection creation rate. Unit: connections per second.</description></item>
        /// <item><description><b>ActiveSessionCount</b>: number of concurrent connections. Unit: connections.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBps</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the NAT gateway is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of entries to return for real-time SNAT performance ranking. Valid values: <b>1 to 100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

    }

}
