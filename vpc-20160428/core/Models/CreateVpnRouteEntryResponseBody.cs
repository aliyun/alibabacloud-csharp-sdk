// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp when the destination-based route was created. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492747187000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the destination-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The next hop of the destination-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-bp15oes1py4i66rmd****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The tunneling protocol. The value is set to <b>Ipsec</b>, which indicates the IPsec tunneling protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ipsec</para>
        /// </summary>
        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the destination-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// <para>The status of the destination-based route.</para>
        /// <list type="bullet">
        /// <item><description><b>published</b>: advertised to the VPC route table.</description></item>
        /// <item><description><b>normal</b>: not advertised to the VPC route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>published</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1a3kqjiiq9legfx****</para>
        /// </summary>
        [NameInMap("VpnInstanceId")]
        [Validation(Required=false)]
        public string VpnInstanceId { get; set; }

        /// <summary>
        /// <para>The weight of the destination-based route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>100</b>: a high priority</description></item>
        /// <item><description><b>0</b>: a low priority</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
