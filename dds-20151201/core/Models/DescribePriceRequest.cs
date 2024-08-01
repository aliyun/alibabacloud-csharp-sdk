// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// The business information. This is an additional parameter.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The code of the instance. Valid values:
        /// 
        /// *   **dds**: a replica set instance that uses the pay-as-you-go billing method
        /// *   **badds**: a replica set instance that uses the subscription billing method
        /// *   **dds_sharding**: a sharded cluster instance that uses the pay-as-you-go billing method
        /// *   **badds_sharding**: a sharded cluster instance that uses the subscription billing method
        /// *   **badds_sharding_intl**: a sharded cluster instance that uses the subscription billing method and is available on the International site (alibabacloud.com)
        /// *   **dds_sharding_intl**: a sharded cluster instance that uses the pay-as-you-go billing method and is available on the International site (alibabacloud.com)
        /// *   **badds_sharding_jp**: a sharded cluster instance that uses the subscription billing method and is available on the Japan site (jp.alibabacloud.com)
        /// *   **badds_intl**: a replica set instance that uses the subscription billing method and is available on the International site (alibabacloud.com)
        /// *   **dds_intl**: a replica set instance that uses the pay-as-you-go billing method and is available on the International site (alibabacloud.com)
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Default value: null. Valid values:
        /// 
        /// *   **default** or **null**: uses coupons.
        /// *   **youhuiquan_promotion_option_id_for_blank**: does not use coupons.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// A JSON string that contains the details of the instance. For more information about the parameter and sample JSON formats, see [DescribePrice](https://help.aliyun.com/document_detail/197291.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public string DBInstances { get; set; }

        /// <summary>
        /// Specifies whether to return the OrderParams parameter. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("OrderParamOut")]
        [Validation(Required=false)]
        public string OrderParamOut { get; set; }

        /// <summary>
        /// The order type. Valid values:
        /// 
        /// *   **BUY**
        /// *   **UPGRADE**
        /// *   **RENEW**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The code of the service. Default value: **dds**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61933.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. For more information, see [View basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
