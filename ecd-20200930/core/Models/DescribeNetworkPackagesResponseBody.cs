// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNetworkPackagesResponseBody : TeaModel {
        /// <summary>
        /// The premium bandwidth plans.
        /// </summary>
        [NameInMap("NetworkPackages")]
        [Validation(Required=false)]
        public List<DescribeNetworkPackagesResponseBodyNetworkPackages> NetworkPackages { get; set; }
        public class DescribeNetworkPackagesResponseBodyNetworkPackages : TeaModel {
            /// <summary>
            /// The bandwidth provided by the premium bandwidth plan. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The business status.
            /// 
            /// Valid values:
            /// 
            /// *   Expired
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Normal
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The time when the premium bandwidth plan was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The public egress IP address of the premium bandwidth plan.
            /// </summary>
            [NameInMap("EipAddresses")]
            [Validation(Required=false)]
            public List<string> EipAddresses { get; set; }

            /// <summary>
            /// The time when the premium bandwidth plan expires.
            /// 
            /// *   If the plan is a subscription one, the time when the plan expires is returned.
            /// *   If the plan is a pay-as-you-go one, `2099-12-31T15:59:59Z` is returned.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The charge type of the premium bandwidth plan.
            /// 
            /// *   Valid value when the `PayType` parameter is set to `PrePaid`:
            /// 
            ///     *   PayByBandwidth: charges by fixed bandwidth.
            /// 
            /// *   Valid values when the `PayType` parameter is set to `PostPaid`:
            /// 
            ///     *   PayByTraffic: charges by data transfer.
            ///     *   PayByBandwidth: charges by fixed bandwidth.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The ID of the premium bandwidth plan.
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// The status of the premium bandwidth plan.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Released
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   InUse
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Releasing
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("NetworkPackageStatus")]
            [Validation(Required=false)]
            public string NetworkPackageStatus { get; set; }

            /// <summary>
            /// The office network ID.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The office network name.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The type of the office network.
            /// 
            /// Valid values:
            /// 
            /// *   standard: advanced office network
            /// *   customized: custom office network
            /// *   basic: basic office network
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// The billing method of the premium bandwidth plan.
            /// 
            /// Valid values:
            /// 
            /// *   PostPaid: pay-as-you-go
            /// *   PrePaid: subscription
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The time when the reserved network bandwidth took effect.
            /// </summary>
            [NameInMap("ReservationActiveTime")]
            [Validation(Required=false)]
            public string ReservationActiveTime { get; set; }

            /// <summary>
            /// The peak bandwidth that is reserved for the premium bandwidth plan. Unit: Mbit/s.
            /// </summary>
            [NameInMap("ReservationBandwidth")]
            [Validation(Required=false)]
            public int? ReservationBandwidth { get; set; }

            /// <summary>
            /// The billing method of the reserved network bandwidth.
            /// 
            /// Valid values:
            /// 
            /// *   PayByTraffic: charges by data transfer.
            /// 
            /// *   PayByBandwidth: charges by fixed bandwidth.
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
