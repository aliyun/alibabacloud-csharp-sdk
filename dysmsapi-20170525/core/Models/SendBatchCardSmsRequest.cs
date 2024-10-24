// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsRequest : TeaModel {
        /// <summary>
        /// <para>The code of the message template. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_3245</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the card message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;customurl\&quot;:\&quot;<a href="http://www.alibaba.com%5C%5C%22,%5C%5C%22dyncParams%5C%5C%22:%5C%5C%22%7B%5C%5C%5C%5C%5C%5C%22a%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22hello%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%22b%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22world%5C%5C%5C%5C%5C%5C%22%7D%5C%5C%22%7D%5D">http://www.alibaba.com\\&quot;,\\&quot;dyncParams\\&quot;:\\&quot;{\\\\\\&quot;a\\\\\\&quot;:\\\\\\&quot;hello\\\\\\&quot;,\\\\\\&quot;b\\\\\\&quot;:\\\\\\&quot;world\\\\\\&quot;}\\&quot;}]</a></para>
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The code of the digital message template that applies when the card message is rolled back. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DIGITAL_SMS_234080176</para>
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the digital message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;a&quot;:1,&quot;b&quot;:2},{&quot;a&quot;:9,&quot;b&quot;:8}]</para>
        /// </summary>
        [NameInMap("DigitalTemplateParamJson")]
        [Validation(Required=false)]
        public string DigitalTemplateParamJson { get; set; }

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
        /// <para>16545681783595370</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The mobile numbers of the recipients.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;1390000****\&quot;,\&quot;1370000****\&quot;]&quot;</para>
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        /// <summary>
        /// <para>The signature. You can view the template code in the <b>Signature</b> column on the <b>Signaturess</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>The signatures must be approved and correspond to the mobile numbers in sequence.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;aliyun\&quot;,\&quot;aliyuncode\&quot;]</para>
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        /// <summary>
        /// <para>The code of the text message template that applies when the card message is rolled back. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_234251075</para>
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// <para>The variables of the text message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;a&quot;:1,&quot;b&quot;:2},{&quot;a&quot;:9,&quot;b&quot;:8}]</para>
        /// </summary>
        [NameInMap("SmsTemplateParamJson")]
        [Validation(Required=false)]
        public string SmsTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The extension code of the upstream message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;6\&quot;,\&quot;6\&quot;]</para>
        /// </summary>
        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// <para>You can log on to the <a href="https://dysms.console.aliyun.com/dysms.htm?spm=5176.12818093.categories-n-products.ddysms.3b2816d0xml2NA#/overview">Alibaba Cloud console</a>, click <b>Go China</b> or <b>Go Globe</b> in the left-side navigation pane, and then view the <b>template code</b> on the <b>Templates</b> tab.</para>
        /// <remarks>
        /// <para>You must specify a message template that is created in the SMS console and approved by Alibaba Cloud. If you send messages to countries or regions outside the Chinese mainland, use the corresponding message templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_20375****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The value of the variable in the message template.</para>
        /// <remarks>
        /// <para>If you need to add line breaks to the JSON template, make sure that the format is valid. In addition, the sequence of variable values must be the same as that of the mobile numbers and signatures.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;TemplateParamJson&quot;},{&quot;name&quot;:&quot;TemplateParamJson&quot;}]</para>
        /// </summary>
        [NameInMap("TemplateParamJson")]
        [Validation(Required=false)]
        public string TemplateParamJson { get; set; }

    }

}
