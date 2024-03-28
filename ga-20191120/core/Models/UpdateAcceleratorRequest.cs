// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateAcceleratorRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false**: disables automatic payment. This is the default value. After an order is generated, you must go to the [Order Center](https://usercenter2-intl.aliyun.com/order/list) to complete the payment.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// 
        /// >  This parameter takes effect only if you call the operation to upgrade a GA instance.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to automatically pay bills by using coupons. Default value: false. Valid values:
        /// 
        /// *   **true**: automatically pays bills by using coupons.
        /// *   **false**: does not automatically pay bills by using coupons.
        /// 
        /// >  This parameter takes effect only if the **AutoPay** parameter is set to **true**.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the GA instance. The description can be up to 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the GA instance.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The specification of the GA instance. Valid values:
        /// 
        /// *   **1**: Small Ⅰ
        /// *   **2**: Small Ⅱ
        /// *   **3**: Small Ⅲ
        /// *   **5**: Medium Ⅰ
        /// *   **8**: Medium Ⅱ
        /// *   **10**: Medium Ⅲ
        /// *   **20**: Large Ⅰ
        /// *   **30**: Large Ⅱ
        /// *   **40**: Large Ⅲ
        /// *   **50**: Large Ⅳ
        /// *   **60**: Large Ⅴ
        /// *   **70**: Large Ⅵ
        /// *   **80**: Large VⅡ
        /// *   **90**: Large VⅢ
        /// *   **100**: Super Large Ⅰ
        /// *   **200**: Super Large Ⅱ
        /// 
        /// >  The Large Ⅲ specification and higher specifications are available only for accounts that are added to the whitelist. To use these specifications, contact your Alibaba Cloud account manager.
        /// 
        /// Different specifications provide different capabilities. For more information, see [Instance specifications](~~153127~~).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
