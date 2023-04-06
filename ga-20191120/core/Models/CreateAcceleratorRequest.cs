// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAcceleratorRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false:** disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated. This is the default value.
        /// *   **true:** enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true:** enables auto-renewal.
        /// *   **false:** disables auto-renewal. This is the default value.
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
        /// *   **true:** automatically pays bills by using coupons.
        /// *   **false:** does not automatically pay bills by using coupons. This is the default value.
        /// 
        /// >  This parameter takes effect only if **AutoPay** is set to **true**.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// The bandwidth billing method.
        /// 
        /// *   **BandwidthPackage:** billed based on bandwidth plans.
        /// *   **CDT:** billed based on data transfer.
        /// *   **CDT95:** billed based on the 95th percentile bandwidth. The billing is managed by Cloud Data Transfer (CDT). This bandwidth billing method is available only for users that are included in the whitelist.
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the value of **RequestId**as the value of **ClientToken**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subscription duration of the GA instance.
        /// 
        /// *   If the **PricingCycle** parameter is set to **Month**, the valid values for the **Duration** parameter are **1** to **9**.
        /// *   If the **PricingCycle** parameter is set to **Year**, the valid values for the **Duration** parameter are **1** to **3**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The configurations of the acceleration area.
        /// </summary>
        [NameInMap("IpSetConfig")]
        [Validation(Required=false)]
        public CreateAcceleratorRequestIpSetConfig IpSetConfig { get; set; }
        public class CreateAcceleratorRequestIpSetConfig : TeaModel {
            /// <summary>
            /// The access mode of the acceleration area. Valid values:
            /// 
            /// *   **UserDefine:** custom nearby access mode. You can select acceleration areas and regions based on your business requirements. GA allocates a separate elastic IP address (EIP) to each acceleration region.
            /// *   **Anycast:** automatic nearby access mode. You do not need to specify an acceleration area. GA allocates an Anycast EIP to multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud global transmission network by sending requests to the Anycast EIP.
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

        }

        /// <summary>
        /// The name of the GA instance.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The billing cycle of the GA instance. Valid values:
        /// 
        /// *   **Month**: billed on a monthly basis.
        /// *   **Year**: billed on an annual basis.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The coupon code.
        /// 
        /// >  This parameter is available only on the Alibaba International Site (alibabacloud.com).
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the standard GA instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The specification of the GA instance. Valid values:
        /// 
        /// *   **1:** Small Ⅰ
        /// *   **2:** Small Ⅱ
        /// *   **3:** Small Ⅲ
        /// *   **5:** Medium Ⅰ
        /// *   **8:** Medium Ⅱ
        /// *   **10:** Medium Ⅲ
        /// *   **20:** Large Ⅰ
        /// *   **30:** Large Ⅱ
        /// *   **40:** Large Ⅲ
        /// *   **50:** Large Ⅳ
        /// *   **60:** Large Ⅴ
        /// *   **70:** Large Ⅵ
        /// *   **80:** Large VⅡ
        /// *   **90:** Large VⅢ
        /// *   **100:** Super Large Ⅰ
        /// *   **200:** Super Large Ⅱ
        /// 
        /// >  The Large Ⅲ specification and higher specifications are available only for accounts that are added to the whitelist. To use these specifications, contact your Alibaba Cloud account manager.
        /// 
        /// Different specifications provide different capabilities. For more information, see [Instance specifications](~~153127~~).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAcceleratorRequestTag> Tag { get; set; }
        public class CreateAcceleratorRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
