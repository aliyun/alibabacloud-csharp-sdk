// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>826B6280-9704-5643-97B1-6B47AC3F027A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of assets protected all types of firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalAssets")]
        [Validation(Required=false)]
        public long? TotalAssets { get; set; }

        /// <summary>
        /// <para>The volume of burstable protected traffic for which fees are generated. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalBillTraffic")]
        [Validation(Required=false)]
        public long? TotalBillTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets protected by the Internet firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("TotalInternetAssets")]
        [Validation(Required=false)]
        public long? TotalInternetAssets { get; set; }

        /// <summary>
        /// <para>The total traffic for the Internet firewall. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the Internet boundary. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalInternetTraffic")]
        [Validation(Required=false)]
        public long? TotalInternetTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets protected by NAT firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNatAssets")]
        [Validation(Required=false)]
        public long? TotalNatAssets { get; set; }

        /// <summary>
        /// <para>The total traffic for NAT firewalls. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the NAT boundary. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>560646279</para>
        /// </summary>
        [NameInMap("TotalNatTraffic")]
        [Validation(Required=false)]
        public long? TotalNatTraffic { get; set; }

        /// <summary>
        /// <para>The total volume of traffic. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets protected by virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalVpcAssets")]
        [Validation(Required=false)]
        public long? TotalVpcAssets { get; set; }

        /// <summary>
        /// <para>The total traffic for VPC firewalls. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the VPC boundary. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalVpcTraffic")]
        [Validation(Required=false)]
        public long? TotalVpcTraffic { get; set; }

    }

}
