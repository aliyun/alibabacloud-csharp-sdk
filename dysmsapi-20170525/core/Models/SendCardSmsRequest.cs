// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendCardSmsRequest : TeaModel {
        /// <summary>
        /// <para>The objects of the message template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CardObjects")]
        [Validation(Required=false)]
        public List<SendCardSmsRequestCardObjects> CardObjects { get; set; }
        public class SendCardSmsRequestCardObjects : TeaModel {
            /// <summary>
            /// <para>The URL to which the message is redirected if the message fails to be rendered.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alibaba.com">https://alibaba.com</a></para>
            /// </summary>
            [NameInMap("customUrl")]
            [Validation(Required=false)]
            public string CustomUrl { get; set; }

            /// <summary>
            /// <para>The variables. Special characters, such as $ and {}, do not need to be entered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;param3\&quot;:\&quot;three\&quot;,\&quot;param1\&quot;:\&quot;one\&quot;,\&quot;param2\&quot;:\&quot;two\&quot;}</para>
            /// </summary>
            [NameInMap("dyncParams")]
            [Validation(Required=false)]
            public string DyncParams { get; set; }

            /// <summary>
            /// <para>The mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        /// <summary>
        /// <para>The code of the message template. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_70</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The code of the digital message template that applies when the card message is rolled back. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_003</para>
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the digital message template.</para>
        /// <remarks>
        /// <para>If you need to add line breaks to the JSON template, make sure that the format is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;msg\&quot;,\&quot;xxxd\&quot;}</para>
        /// </summary>
        [NameInMap("DigitalTemplateParam")]
        [Validation(Required=false)]
        public string DigitalTemplateParam { get; set; }

        /// <summary>
        /// <para>The rollback type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SMS</b>: text message</description></item>
        /// <item><description><b>DIGITALSMS</b>: digital message</description></item>
        /// <item><description><b>NONE</b>: none</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS</para>
        /// </summary>
        [NameInMap("FallbackType")]
        [Validation(Required=false)]
        public string FallbackType { get; set; }

        /// <summary>
        /// <para>The ID that is reserved for the caller of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38d76c9b-4a9a-4c89-afae-61fd8e0e****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The signature. You can view the template code in the <b>Signature</b> column on the <b>Signaturess</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>The signature must be approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The code of the text message template that applies when the card message is rolled back. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved. If you set the <b>FallbackType</b> parameter to <b>SMS</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SIER_TEST_01</para>
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the text message template.</para>
        /// <remarks>
        /// <para>If you need to add line breaks to the JSON template, make sure that the format is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;uri\&quot;:\&quot;Zg11tZ\&quot;}</para>
        /// </summary>
        [NameInMap("SmsTemplateParam")]
        [Validation(Required=false)]
        public string SmsTemplateParam { get; set; }

        /// <summary>
        /// <para>The extension code of the upstream message. Upstream messages are messages sent to the communication service provider. Upstream messages are used to customize a service, complete an inquiry, or send a request. You are charged for sending upstream messages based on the billing standards of the service provider.</para>
        /// <remarks>
        /// <para>If you do not need upstream messages, ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// <para>The code of the text message template.</para>
        /// <para>Log on to the Alibaba Cloud SMS console. In the left-side navigation pane, click <b>Go Globe</b> or <b>Go China</b>. You can view the message template in the <b>Template Code</b> column on the <b>Message Templates</b> tab.</para>
        /// <remarks>
        /// <para>The message templates must be created on the Go Globe page and approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_2322****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the message template. Format: JSON.</para>
        /// <remarks>
        /// <para>If you need to add line breaks to the JSON template, make sure that the format is valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       \&quot;code\&quot;: \&quot;1111\&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

    }

}
