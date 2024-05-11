// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertContactRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact to be updated. You can call the SearchAlertContact operation to query the contact ID. For more information, see [SearchAlertContact](https://help.aliyun.com/document_detail/130703.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// The new name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The new webhook URL of the DingTalk chatbot. For more information, see [Configure a DingTalk chatbot to send alert notifications](https://help.aliyun.com/document_detail/106247.html). You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// 
        /// >  If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.
        /// </summary>
        [NameInMap("DingRobotWebhookUrl")]
        [Validation(Required=false)]
        public string DingRobotWebhookUrl { get; set; }

        /// <summary>
        /// The new email address of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// 
        /// >  If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The new mobile phone number of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.
        /// 
        /// >  If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.
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
