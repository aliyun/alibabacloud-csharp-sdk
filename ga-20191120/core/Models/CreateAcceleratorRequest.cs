// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAcceleratorRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: false. Valid values:
        /// 
        /// *   **false:** disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true:** enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the GA instance. Default value: false. Valid values:
        /// 
        /// *   **true:** enables auto-renewal.
        /// *   **false:** disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: months.
        /// 
        /// Valid values: **1** to **12**. Default value: **1**.
        /// 
        /// >  This parameter takes effect only when **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// Specifies whether to automatically use coupons when making payments. Default value: false. Valid values:
        /// 
        /// *   **true:** automatically pays bill by using coupons.
        /// *   **false:** does not automatically pay bills by using coupons.
        /// 
        /// >  This parameter takes effect only when **AutoPay** is set to **true**.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// The bandwidth billing method.
        /// 
        /// *   **BandwidthPackage:** billed based on bandwidth plans.
        /// *   **CDT:** billed based on data transfer.
        /// *   **CDT95:** billed based on the 95th percentile bandwidth. The billing is managed by Cloud Data Transfer (CDT). This bandwidth billing method is not available by default. Contact your Alibaba Cloud account manager for more information.
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system sets **ClientToken** to the value of **RequestId**. The value of **RequestId** of each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Default value: false. Valid values:
        /// 
        /// *   **true**: prechecks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
        /// The billing method of the GA. Default value is PREPAY (subscription).
        /// 
        /// *   PREPAY : subscription.
        /// *   POSTPAY : pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

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
            /// *   **UserDefine:** custom nearby access mode. You can select acceleration areas and regions based on your business requirements. GA allocates a separate EIP to each acceleration region.
            /// *   **Anycast:** automatic nearby access mode. You do not need to specify an acceleration area. GA allocates an Anycast EIP to multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud global transmission network by sending requests to the Anycast EIP.
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

        }

        /// <summary>
        /// The name of the GA instance.
        /// 
        /// The name must be 2 to 128 characters in length and can contain digits, underscores (_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The billing cycle of the GA instance. Valid values:
        /// 
        /// *   **Month:** billed on a monthly basis.
        /// *   **Year:** billed on an annual basis.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The coupon code.
        /// 
        /// >
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// The ID of the region in which to create the GA instance. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
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
        /// The type of GA instance. Valid values:
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
        /// >  GA instances Large III and above are not available by default. To use these instances , contact your Alibaba Cloud account manager.
        /// 
        /// Each instance type provides different capabilities. For more information, see [Instance specifications](https://help.aliyun.com/document_detail/153127.html).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The tags of the GA instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAcceleratorRequestTag> Tag { get; set; }
        public class CreateAcceleratorRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the GA instance. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the GA instance. The tag value cannot be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
