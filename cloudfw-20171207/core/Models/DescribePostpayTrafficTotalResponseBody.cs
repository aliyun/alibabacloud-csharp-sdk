// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficTotalResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of assets protected all types of firewalls.
        /// </summary>
        [NameInMap("TotalAssets")]
        [Validation(Required=false)]
        public long? TotalAssets { get; set; }

        /// <summary>
        /// The volume of burstable protected traffic for which fees are generated. Unit: bytes.
        /// </summary>
        [NameInMap("TotalBillTraffic")]
        [Validation(Required=false)]
        public long? TotalBillTraffic { get; set; }

        /// <summary>
        /// The total number of assets protected by the Internet firewall.
        /// </summary>
        [NameInMap("TotalInternetAssets")]
        [Validation(Required=false)]
        public long? TotalInternetAssets { get; set; }

        /// <summary>
        /// The total traffic for the Internet firewall. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the Internet boundary. Unit: bytes.
        /// </summary>
        [NameInMap("TotalInternetTraffic")]
        [Validation(Required=false)]
        public long? TotalInternetTraffic { get; set; }

        /// <summary>
        /// The total number of assets protected by NAT firewalls.
        /// </summary>
        [NameInMap("TotalNatAssets")]
        [Validation(Required=false)]
        public long? TotalNatAssets { get; set; }

        /// <summary>
        /// The total traffic for NAT firewalls. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the NAT boundary. Unit: bytes.
        /// </summary>
        [NameInMap("TotalNatTraffic")]
        [Validation(Required=false)]
        public long? TotalNatTraffic { get; set; }

        /// <summary>
        /// The total volume of traffic. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic. Unit: bytes.
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

        /// <summary>
        /// The total number of assets protected by virtual private cloud (VPC) firewalls.
        /// </summary>
        [NameInMap("TotalVpcAssets")]
        [Validation(Required=false)]
        public long? TotalVpcAssets { get; set; }

        /// <summary>
        /// The total traffic for VPC firewalls. If you use Cloud Firewall that uses the subscription billing method, this parameter indicates the total volume of burstable protected traffic on the VPC boundary. Unit: bytes.
        /// </summary>
        [NameInMap("TotalVpcTraffic")]
        [Validation(Required=false)]
        public long? TotalVpcTraffic { get; set; }

    }

}
