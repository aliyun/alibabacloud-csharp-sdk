// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance that is associated with the bandwidth plan.
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<string> Accelerators { get; set; }

        /// <summary>
        /// The bandwidth value of the bandwidth plan. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The type of the bandwidth. Valid values:
        /// 
        /// *   **Basic**: basic bandwidth
        /// *   **Enhanced**: enhanced bandwidth
        /// *   **Advanced**: premium bandwidth
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The metering method that is used when you use the pay-as-you-go billing method. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayBY95**: pay-by-95th-percentile
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// Area A specified in the cross-region acceleration bandwidth plan. Only **China-mainland** (the Chinese mainland) is returned.
        /// 
        /// This parameter is returned only if you call this operation on the International site (alibabacloud.com).
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// Area B specified in the cross-region acceleration bandwidth plan. Only **Global** (global) is returned.
        /// 
        /// This parameter is returned only if you call this operation on the International site (alibabacloud.com).
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// The billing method of the bandwidth plan. Only **PREPAY** is returned, which indicates the subscription billing method.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The timestamp that indicates when the bandwidth plan was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the bandwidth plan.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The timestamp that indicates when the bandwidth plan expires.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// The name of the bandwidth plan.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The percentage of the minimum bandwidth guaranteed if the pay-by-95th-percentile-bandwidth metering method is used. Valid values: **30** to **100**.
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// The ID of the region where GA instance is deployed. **cn-hangzhou** is returned.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The state of the bandwidth plan. Valid values:
        /// 
        /// *   **init**: The bandwidth plan is being initialized.
        /// *   **active**: The bandwidth plan is available.
        /// *   **binded**: The bandwidth plan is associated with a GA instance.
        /// *   **binding**: The bandwidth plan is being associated.
        /// *   **unbinding**: The bandwidth plan is being disassociated.
        /// *   **updating**: The bandwidth plan is being updated.
        /// *   **finacialLocked**: The bandwidth plan is locked due to overdue payments.
        /// *   **Locked**: The bandwidth plan is locked.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeBandwidthPackageResponseBodyTags> Tags { get; set; }
        public class DescribeBandwidthPackageResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the bandwidth plan. Valid values:
        /// 
        /// *   **Basic**: a basic bandwidth plan
        /// *   **CrossDomain**: a cross-region acceleration bandwidth plan
        /// 
        /// If you call this operation on the Alibaba Cloud China Site (aliyun.com), only **Basic** is returned.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
