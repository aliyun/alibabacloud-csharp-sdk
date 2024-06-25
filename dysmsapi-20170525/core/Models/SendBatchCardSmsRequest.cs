// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsRequest : TeaModel {
        /// <summary>
        /// The code of the message template. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// The variables of the card message template.
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// The code of the digital message template that applies when the card message is rolled back. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// The variables of the digital message template.
        /// </summary>
        [NameInMap("DigitalTemplateParamJson")]
        [Validation(Required=false)]
        public string DigitalTemplateParamJson { get; set; }

        /// <summary>
        /// The rollback type. Valid values:
        /// 
        /// *   **SMS**: text message
        /// *   **DIGITALSMS**: digital message
        /// *   **NONE**: none
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FallbackType")]
        [Validation(Required=false)]
        public string FallbackType { get; set; }

        /// <summary>
        /// The ID that is reserved for the caller of the operation.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// The mobile numbers of the recipients.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        /// <summary>
        /// The signature. You can view the template code in the **Signature** column on the **Signaturess** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > The signatures must be approved and correspond to the mobile numbers in sequence.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        /// <summary>
        /// The code of the text message template that applies when the card message is rolled back. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// The variables of the text message template.
        /// </summary>
        [NameInMap("SmsTemplateParamJson")]
        [Validation(Required=false)]
        public string SmsTemplateParamJson { get; set; }

        /// <summary>
        /// The extension code of the upstream message.
        /// </summary>
        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        /// <summary>
        /// The code of the message template.
        /// 
        /// You can log on to the [Alibaba Cloud console](https://dysms.console.aliyun.com/dysms.htm?spm=5176.12818093.categories-n-products.ddysms.3b2816d0xml2NA#/overview), click **Go China** or **Go Globe** in the left-side navigation pane, and then view the **template code** on the **Templates** tab.
        /// 
        /// > You must specify a message template that is created in the SMS console and approved by Alibaba Cloud. If you send messages to countries or regions outside the Chinese mainland, use the corresponding message templates.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The value of the variable in the message template.
        /// 
        /// > If you need to add line breaks to the JSON template, make sure that the format is valid. In addition, the sequence of variable values must be the same as that of the mobile numbers and signatures.
        /// </summary>
        [NameInMap("TemplateParamJson")]
        [Validation(Required=false)]
        public string TemplateParamJson { get; set; }

    }

}
