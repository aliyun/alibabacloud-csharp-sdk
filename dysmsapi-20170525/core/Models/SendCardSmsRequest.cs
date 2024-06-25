// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendCardSmsRequest : TeaModel {
        /// <summary>
        /// The objects of the message template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CardObjects")]
        [Validation(Required=false)]
        public List<SendCardSmsRequestCardObjects> CardObjects { get; set; }
        public class SendCardSmsRequestCardObjects : TeaModel {
            /// <summary>
            /// The URL to which the message is redirected if the message fails to be rendered.
            /// </summary>
            [NameInMap("customUrl")]
            [Validation(Required=false)]
            public string CustomUrl { get; set; }

            /// <summary>
            /// The variables. Special characters, such as $ and {}, do not need to be entered.
            /// </summary>
            [NameInMap("dyncParams")]
            [Validation(Required=false)]
            public string DyncParams { get; set; }

            /// <summary>
            /// The mobile phone number.
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

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
        /// The code of the digital message template that applies when the card message is rolled back. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// The variables of the digital message template.
        /// 
        /// > If you need to add line breaks to the JSON template, make sure that the format is valid.
        /// </summary>
        [NameInMap("DigitalTemplateParam")]
        [Validation(Required=false)]
        public string DigitalTemplateParam { get; set; }

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
        /// The signature. You can view the template code in the **Signature** column on the **Signaturess** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > The signature must be approved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// The code of the text message template that applies when the card message is rolled back. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved. If you set the **FallbackType** parameter to **SMS**, this parameter is required.
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// The variables of the text message template.
        /// 
        /// > If you need to add line breaks to the JSON template, make sure that the format is valid.
        /// </summary>
        [NameInMap("SmsTemplateParam")]
        [Validation(Required=false)]
        public string SmsTemplateParam { get; set; }

        /// <summary>
        /// The extension code of the upstream message. Upstream messages are messages sent to the communication service provider. Upstream messages are used to customize a service, complete an inquiry, or send a request. You are charged for sending upstream messages based on the billing standards of the service provider.
        /// 
        /// > If you do not need upstream messages, ignore this parameter.
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// The code of the text message template.
        /// 
        /// Log on to the Alibaba Cloud SMS console. In the left-side navigation pane, click **Go Globe** or **Go China**. You can view the message template in the **Template Code** column on the **Message Templates** tab.
        /// 
        /// > The message templates must be created on the Go Globe page and approved.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The variables of the message template. Format: JSON.
        /// 
        /// > If you need to add line breaks to the JSON template, make sure that the format is valid.
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

    }

}
