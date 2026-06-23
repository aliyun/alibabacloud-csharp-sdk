// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the returned results are displayed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese.</description></item>
        /// <item><description><b>en-US</b> (default): English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The VPN gateway type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Traditional</b>: Returns zone information for creating traditional VPN gateways.</description></item>
        /// <item><description><b>Enhanced.SiteToSite</b>: Returns zone information for creating enhanced site-to-cloud VPN gateways.</description></item>
        /// <item><description><b>Default value</b>: Returns zone information for creating all types of VPN gateways.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Traditional</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification.</para>
        /// <list type="bullet">
        /// <item><description>If the IPsec-VPN connection is associated with a VPN gateway instance, this parameter specifies the bandwidth specification of the VPN gateway instance.</description></item>
        /// <item><description>If the IPsec-VPN connection is associated with a transit router, this parameter specifies the expected bandwidth specification that the IPsec-VPN connection can support.</description></item>
        /// </list>
        /// <para>Different bandwidth specifications may affect the zone information returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5M</b></description></item>
        /// <item><description><b>10M</b></description></item>
        /// <item><description><b>20M</b></description></item>
        /// <item><description><b>50M</b></description></item>
        /// <item><description><b>100M</b></description></item>
        /// <item><description><b>200M</b></description></item>
        /// <item><description><b>500M</b></description></item>
        /// <item><description><b>1000M</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
