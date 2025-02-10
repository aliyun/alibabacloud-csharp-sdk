// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next requests are performed.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListVpcEndpointZonesResponseBodyZones> Zones { get; set; }
        public class ListVpcEndpointZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-hp3c8qj1tyct8aqy****</para>
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// <para>The IP address of the endpoint ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.23</para>
            /// </summary>
            [NameInMap("EniIp")]
            [Validation(Required=false)]
            public string EniIp { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in the zone. The system automatically creates an endpoint elastic network interface (ENI) in the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hjkshjvdkdvd****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The domain name of the zone.</para>
            /// <para>After the endpoint in the zone is connected to the endpoint service, you can access the service resources of the endpoint service by using the domain name of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-hp3f033dp24c5yc9****-cn-huhehaote.epsrv-hp3itcpowf37m3d5****.cn-huhehaote-a.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ZoneDomain")]
            [Validation(Required=false)]
            public string ZoneDomain { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>Indicates whether the endpoint service supports IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ZoneIpv6Address")]
            [Validation(Required=false)]
            public string ZoneIpv6Address { get; set; }

            /// <summary>
            /// <para>The state of the zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The zone is being created.</description></item>
            /// <item><description><b>Wait</b>: The zone is to be connected.</description></item>
            /// <item><description><b>Connected</b>: The zone is connected.</description></item>
            /// <item><description><b>Deleting</b>: The zone is being deleted.</description></item>
            /// <item><description><b>Disconnecting</b>: The zone is being disconnected.</description></item>
            /// <item><description><b>Disconnected</b>: The zone is disconnected.</description></item>
            /// <item><description><b>Connecting</b>: The zone is being connected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Wait</para>
            /// </summary>
            [NameInMap("ZoneStatus")]
            [Validation(Required=false)]
            public string ZoneStatus { get; set; }

        }

    }

}
