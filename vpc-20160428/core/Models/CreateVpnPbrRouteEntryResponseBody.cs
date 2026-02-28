// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnPbrRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp generated when the policy-based route was created. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492747187000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The tunneling protocol. The value is <b>Ipsec</b>.</para>
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
        /// <para>The priority of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The priority of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The VPN gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// <para>The source CIDR block of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24</para>
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// <para>The status of the policy-based route.</para>
        /// <list type="bullet">
        /// <item><description><b>published</b>: advertised to the VPC route table.</description></item>
        /// <item><description><b>normal</b>: not advertised to the VPC route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1cmw7jh1nfe43m9****</para>
        /// </summary>
        [NameInMap("VpnInstanceId")]
        [Validation(Required=false)]
        public string VpnInstanceId { get; set; }

        /// <summary>
        /// <para>The source CIDR block of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
