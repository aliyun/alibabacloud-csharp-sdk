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
        /// <item><description><b>zh-CN</b>: Chinese</description></item>
        /// <item><description><b>en-US</b> (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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
        /// <item><description>If an IPsec-VPN connection can be associated with the VPN gateway, this parameter specifies the bandwidth specification of the VPN gateway.</description></item>
        /// <item><description>In scenarios where an IPsec-VPN connection can be associated with a transit router. This parameter specifies the bandwidth specification supported by an IPsec-VPN connection.</description></item>
        /// </list>
        /// <para>Different bandwidth specifications may affect returned zone information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5M</b></description></item>
        /// <item><description><b>10M</b></description></item>
        /// <item><description><b>20M</b></description></item>
        /// <item><description><b>50M</b></description></item>
        /// <item><description><b>100M</b></description></item>
        /// <item><description><b>200M</b></description></item>
        /// <item><description><b>500M</b></description></item>
        /// <item><description><b>1000M</b></description></item>
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
