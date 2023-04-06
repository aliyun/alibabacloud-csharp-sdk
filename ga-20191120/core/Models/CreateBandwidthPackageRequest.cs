// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false** (default): disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false** (default): disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: months.
        /// 
        /// Valid values: **1** to **12**. Default value: **1**.
        /// 
        /// >  This parameter takes effect only if **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// Specifies whether to automatically pay bills by using coupons. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// 
        /// >  This parameter takes effect only if **AutoPay** is set to **true**.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// The bandwidth value of the bandwidth plan. Unit: Mbit/s. Valid values: **2** to **2000**.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The type of bandwidth. Valid values:
        /// 
        /// *   **Basic**: standard
        /// *   **Enhanced**: enhanced
        /// *   **Advanced**: premium
        /// 
        /// If **Type** is set to **Basic**, this parameter is required.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The metering method that is used when you use the pay-as-you-go billing method. Valid values:
        /// 
        /// *   **PayByTraffic** (default): pay-by-data-transfer
        /// *   **PayBY95**: pay-by-95th-percentile By default, the pay-by-95th-percentile metering method is unavailable. If you want to use the metering method, contact your account manager.
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// Area A to be connected. Set the value to **China-mainland**.
        /// 
        /// You can set this parameter only if you call this operation on the international site (alibabacloud.com).
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// Area B to be connected. Set the value to **Global**.
        /// 
        /// You can set this parameter only if you call this operation on the international site (alibabacloud.com).
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PREPAY** (default): subscription
        /// *   **POSTPAY**: pay-as-you-go By default, the pay-as-you-go billing method is unavailable. If you want to use the billing method, contact your account manager.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   If the **PricingCycle** parameter is set to **Month**, the valid values of the **Duration** parameter are **1** to **9**.
        /// *   If the **PricingCycle** parameter is set to **Year**, the valid values of the **Duration** parameter are **1** to **3**.
        /// 
        /// If **ChargeType** is set to **PREPAY**, this parameter is required.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The billing cycle. Valid values:
        /// 
        /// *   **Month**: billed on a monthly basis.
        /// *   **Year**: billed on an annual basis.
        /// 
        /// If **ChargeType** is set to **PREPAY**, this parameter is required.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The coupon code.
        /// 
        /// >  This parameter is available only on the international site.
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// The percentage of the minimum bandwidth guaranteed if the pay-by-95th-percentile-bandwidth metering method is used. Valid values: **30** to **100**.
        /// 
        /// >  This parameter takes effect only if **BillingType** is set to **PayBY95**.
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the bandwidth plan belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateBandwidthPackageRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of bandwidth plan. Valid values:
        /// 
        /// *   **Basic**: a basic bandwidth plan
        /// *   **CrossDomain**: a cross-region acceleration bandwidth plan
        /// 
        /// If you call this operation on the Alibaba Cloud China site, only **Basic** is supported.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
