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
        /// Specifies whether to enable automatic payment. Default value: false. Valid values:
        /// 
        /// *   **false**: disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: enables automatic payment. Payments are automatically completed.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

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
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
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
        /// The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
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
        /// *   **300**: Super Large Ⅲ
        /// 
        /// >  The Large Ⅲ specification and higher specifications are available only for accounts that are added to the whitelist. To use other specifications of GA instances, [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex).
        /// 
        /// Each instance specification provides different capabilities. For more information, see the "Specifications of standard GA instances" section in [Overview](~~153127~~).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
