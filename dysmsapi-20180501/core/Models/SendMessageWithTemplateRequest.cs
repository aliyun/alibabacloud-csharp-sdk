// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateRequest : TeaModel {
        /// <summary>
        /// The signature. To query the signature, log on to the [Short Message Service (SMS) console](https://sms-intl.console.aliyun.com/overview) and navigate to the **Signatures** tab of the **Go China** page.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The extension code of the MO message.
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// The code of the message template. To query the code, log on to the [SMS console](https://sms-intl.console.aliyun.com/overview) and navigate to the **Templates** tab of the **Go China** page.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The value of the variable in the message template. If a variable exists in the template, the parameter is required.
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

        /// <summary>
        /// The mobile phone number to which the message is sent. You must add the country code to the beginning of the mobile phone number. Example: 861503871\*\*\*\*.
        /// 
        /// For more information, see [Dialing codes](https://www.alibabacloud.com/help/zh/short-message-service/latest/dialing-codes).
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// The validity period of the message.
        /// </summary>
        [NameInMap("ValidityPeriod")]
        [Validation(Required=false)]
        public long? ValidityPeriod { get; set; }

    }

}
