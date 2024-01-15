// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNetworkPackagesResponseBody : TeaModel {
        /// <summary>
        /// Details of the Internet access packages.
        /// </summary>
        [NameInMap("NetworkPackages")]
        [Validation(Required=false)]
        public List<DescribeNetworkPackagesResponseBodyNetworkPackages> NetworkPackages { get; set; }
        public class DescribeNetworkPackagesResponseBodyNetworkPackages : TeaModel {
            /// <summary>
            /// The maximum public bandwidth of the Internet access package. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The time when the Internet access package was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The elastic IP addresses (EIPs) of the Internet access package for outbound traffic.
            /// </summary>
            [NameInMap("EipAddresses")]
            [Validation(Required=false)]
            public List<string> EipAddresses { get; set; }

            /// <summary>
            /// The time when the Internet access package expires.
            /// 
            /// *   If the Internet access package is metered on a pay-by-bandwidth basis, the actual expiration time is returned.
            /// *   If the Internet access package is metered on a pay-by-data-transfer basis, 2099-12-31T15:59:59Z is returned.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The billing method of the network bandwidth.
            /// 
            /// *   PayByTraffic: pay-by-data-transfer
            /// *   PayByBandwidth: pay-by-bandwidth
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The ID of the Internet access package.
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// The state of the Internet access package. Valid values:
            /// 
            /// *   Creating
            /// *   InUse
            /// *   Releasing
            /// *   Released
            /// </summary>
            [NameInMap("NetworkPackageStatus")]
            [Validation(Required=false)]
            public string NetworkPackageStatus { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The type of the workspace. Valid values:
            /// 
            /// *   basic
            /// *   standard
            /// *   customized
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// The billing method for the network.
            /// 
            /// *   PrePaid: subscription
            /// *   PostPaid: pay-as-you-go
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The time when the reserved network bandwidth takes effect.
            /// </summary>
            [NameInMap("ReservationActiveTime")]
            [Validation(Required=false)]
            public string ReservationActiveTime { get; set; }

            /// <summary>
            /// The peak bandwidth of the reserved network bandwidth. Unit: Mbit/s.
            /// </summary>
            [NameInMap("ReservationBandwidth")]
            [Validation(Required=false)]
            public int? ReservationBandwidth { get; set; }

            /// <summary>
            /// The billing method of the reserved network bandwidth.
            /// 
            /// *   PayByTraffic: pay-by-data-transfer
            /// *   PayByBandwidth: pay-by-bandwidth
            /// </summary>
            [NameInMap("ReservationInternetChargeType")]
            [Validation(Required=false)]
            public string ReservationInternetChargeType { get; set; }

        }

        /// <summary>
        /// The token that is used to start the next query. If the value of this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
