// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// The synchronized expiration date. If you specify this parameter, the price for renewing a specified instance to the specified synchronized expiration date is queried. Valid values: 1 to 28.
        /// 
        /// For information about how to synchronize the expiration dates of instances, see [Synchronize the expiration dates of instances](https://help.aliyun.com/document_detail/108486.html).
        /// 
        /// > The renewal period-related parameter pair (`Period` and `PeriodUnit`) and the `ExpectedRenewDay` parameter are mutually exclusive.
        /// </summary>
        [NameInMap("ExpectedRenewDay")]
        [Validation(Required=false)]
        public int? ExpectedRenewDay { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The renewal period. Valid values:
        /// 
        /// *   Valid values when the `PriceUnit` parameter is set to `Month`: 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   Valid values when the `PriceUnit` parameter is set to `Year`: 1, 2, 3.
        /// 
        /// Default value: 1.
        /// 
        /// > The renewal period-related parameter pair (`Period` and `PeriodUnit`) and the `ExpectedRenewDay` parameter are mutually exclusive.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal period. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent list of regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource. If the `ResourceType` parameter is set to`  instance `, the value of the `ResourceId` parameter is the ID of the specified instance.``
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to instance.
        /// 
        /// Default value: instance.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
