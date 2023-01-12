// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: false. Valid values:
        /// 
        /// *   **false**: disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the bandwidth plan. Default value: false. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false** disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period. Unit: months.
        /// 
        /// Valid values: **1** to **12**. Default value: **1**.
        /// 
        /// >  This parameter is required only if **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// Specifies whether to automatically pay bills by using coupons. Default value: false. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  This parameter is required only if **AutoPay** is set to **true**.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// The bandwidth of the bandwidth plan. Unit: Mbit/s.
        /// 
        /// Valid values: **2** to **2000**.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The type of the bandwidth. Valid values:
        /// 
        /// *   **Basic**: basic
        /// *   **Enhanced**: enhanced
        /// *   **Advanced**: premium
        /// 
        /// If **Type** is set to **Basic**, this parameter is required.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The metering method that is used when you use the pay-as-you-go billing method. Default value: PayByTraffic. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayBY95**: pay-by-95th-percentile
        /// 
        /// The pay-by-95th-percentile metering method is available only for users that are added to the whitelist. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.11182188.console-base-top.dworkorder.18ae4882n3v6ZW#/ticket/createIndex).
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// Area A to be connected. Set the value to **China-mainland**.
        /// 
        /// You can set this parameter only if you call this operation on the Alibaba Cloud International site.
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// Area B to be connected. Set the value to **Global**.
        /// 
        /// You can set this parameter only if you call this operation on the Alibaba Cloud International site.
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// The billing method of the bandwidth plan. Default value: PREPAY. Valid values:
        /// 
        /// *   **PREPAY**: subscription
        /// *   **POSTPAY**: pay-as-you-go
        /// 
        /// The pay-as-you-go billing method is available only for users that are added to the whitelist. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.11182188.console-base-top.dworkorder.18ae4882n3v6ZW#/ticket/createIndex).
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   If the **PricingCycle** parameter is set to **Month**, the valid values for the **Duration** parameter are **1** to **9**.
        /// *   If the **PricingCycle** parameter is set to **Year**, the valid values for the **Duration** parameter are **1** to **3**.
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

        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// The percentage of the minimum bandwidth guaranteed if the pay-by-95th-percentile-bandwidth metering method is used. Valid values: **30** to **100**.
        /// 
        /// >  This parameter is required only if **BillingType** is set to **PayBY95**.
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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the bandwidth plan. Valid values:
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
