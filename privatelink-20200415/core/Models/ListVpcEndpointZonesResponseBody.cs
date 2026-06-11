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
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is empty, no next page exists.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned, use the value to retrieve the next page of results.</para>
        /// </description></item>
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
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The collection of zone information.</para>
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
            /// <para>The ID of the region where the endpoint is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The vSwitch in the zone. The system automatically creates an endpoint elastic network interface (ENI) in the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hjkshjvdkdvd****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The domain name of the zone.</para>
            /// <para>After an endpoint connection is established, use this domain name to access the service resources of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-hp3f033dp24c5yc9****-cn-huhehaote-a.epsrv-hp3itcpowf37m3d5****.cn-huhehaote.privatelink.aliyuncs.com</para>
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
            /// <para>The IPv6 address of the endpoint ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2408:4005:3b6:<b><b>:6955:c3cb:34c:</b></b></para>
            /// </summary>
            [NameInMap("ZoneIpv6Address")]
            [Validation(Required=false)]
            public string ZoneIpv6Address { get; set; }

            /// <summary>
            /// <para>The status of the zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The zone is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Wait</b>: The zone is waiting to be connected.</para>
            /// </description></item>
            /// <item><description><para><b>Connected</b>: The zone is connected.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The zone is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnecting</b>: The zone is being disconnected.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnected</b>: The zone is disconnected.</para>
            /// </description></item>
            /// <item><description><para><b>Connecting</b>: The zone is being connected.</para>
            /// </description></item>
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
