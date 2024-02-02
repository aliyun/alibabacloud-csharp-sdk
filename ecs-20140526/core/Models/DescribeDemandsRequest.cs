// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDemandsRequest : TeaModel {
        /// <summary>
        /// The ID of the demand. If this parameter is specified, other optional request parameters are ignored.
        /// </summary>
        [NameInMap("DemandId")]
        [Validation(Required=false)]
        public string DemandId { get; set; }

        /// <summary>
        /// The status of the demand or filed resources. Valid values:
        /// 
        /// *   Creating: The demand is being created.
        /// *   Active: The filed resources are being supplied.
        /// *   Expired: The demand has expired.
        /// *   Finished: The filed resources are consumed.
        /// *   Refused: The demand is rejected. To view the reason for rejection, see the `Comment` parameter in the response.
        /// *   Cancelled: The demand is canceled.
        /// </summary>
        [NameInMap("DemandStatus")]
        [Validation(Required=false)]
        public List<string> DemandStatus { get; set; }

        /// <summary>
        /// The source of the instance. Valid values:
        /// 
        /// *   Custom: filed on your own.
        /// *   System (default): filed by Alibaba Cloud.
        /// </summary>
        [NameInMap("DemandType")]
        [Validation(Required=false)]
        public string DemandType { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values: Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.
        /// *   false (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go.
        /// *   PrePaid: subscription.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance type of the instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The instance family of the instance.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the resource. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDemandsRequestTag> Tag { get; set; }
        public class DescribeDemandsRequestTag : TeaModel {
            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID of the resource. You can call the [DescribeZones](~~25610~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
