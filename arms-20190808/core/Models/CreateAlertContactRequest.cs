// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateAlertContactRequest : TeaModel {
        /// <summary>
        /// The name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The webhook URL of the DingTalk chatbot. For more information about how to obtain the URL, see [Configure a DingTalk chatbot to send alert notifications](https://www.alibabacloud.com/help/zh/doc-detail/106247.htm). You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// 
        /// >  Enter `alert` in the custom keyword field of DingTalk chatbot security settings.
        /// </summary>
        [NameInMap("DingRobotWebhookUrl")]
        [Validation(Required=false)]
        public string DingRobotWebhookUrl { get; set; }

        /// <summary>
        /// The email address of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The mobile number of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// The ID of the region. Set the value to `cn-hangzhou`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can obtain the resource group ID in the **Resource Management** console.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether the alert contact receives system notifications. Valid values:
        /// 
        /// *   `true`: The alert contact receives system notifications.
        /// *   `false`: The alert contact does not receive system notifications.
        /// </summary>
        [NameInMap("SystemNoc")]
        [Validation(Required=false)]
        public bool? SystemNoc { get; set; }

    }

}
