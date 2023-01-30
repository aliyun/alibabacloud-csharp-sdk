// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// The password.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The specifications of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether payment is automatically made during renewal. Valid values:
        /// 
        /// *   **True**: Automatic payment is enabled. Make sure that your Alibaba Cloud account has adequate balance.
        /// *   **False**: Automatic payment is disabled. You have to manually pay in the console. Log on to the console. In the upper-right corner, choose **Expenses > User Center**. In the left-side navigation pane, click **Orders**. On the page that appears, find your order and complete the payment.
        /// 
        /// Default value: **False**.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// Specifies whether to skip the Waiting for Traffic Switchover state. During the upgrade or downgrade, a new outbound IP address may be added to the API Gateway instance. The Waiting for Traffic Switchover state is used to remind users of adding the new outbound IP address to the whitelist. If you set the SkipWaitSwitch parameter to true, the instance does not enter the Waiting for Traffic Switchover state when a new outbound IP address is available. Instead, the system sends internal messages to the user.
        /// </summary>
        [NameInMap("ModifyAction")]
        [Validation(Required=false)]
        public string ModifyAction { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SkipWaitSwitch")]
        [Validation(Required=false)]
        public bool? SkipWaitSwitch { get; set; }

        /// <summary>
        /// Specifies whether to upgrade or downgrade the instance. Valid values:
        /// 
        /// *   **UPGRADE**
        /// *   **DOWNGRADE**
        /// 
        /// Default value: **UPGRADE**.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
