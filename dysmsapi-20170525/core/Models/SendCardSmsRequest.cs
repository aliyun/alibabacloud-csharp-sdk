// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendCardSmsRequest : TeaModel {
        /// <summary>
        /// <para>The card message objects.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SendCardSms</para>
        /// </summary>
        [NameInMap("CardObjects")]
        [Validation(Required=false)]
        public List<SendCardSmsRequestCardObjects> CardObjects { get; set; }
        public class SendCardSmsRequestCardObjects : TeaModel {
            /// <summary>
            /// <para>渲染失败后跳转链接。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alibaba.com">https://alibaba.com</a></para>
            /// </summary>
            [NameInMap("customUrl")]
            [Validation(Required=false)]
            public string CustomUrl { get; set; }

            /// <summary>
            /// <para>动态参数。动参变量不需要${}</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;param3&quot;:&quot;李四3&quot;,&quot;param1&quot;:&quot;李四&quot;,&quot;param2&quot;:&quot;李四2&quot;}</para>
            /// </summary>
            [NameInMap("dyncParams")]
            [Validation(Required=false)]
            public string DyncParams { get; set; }

            /// <summary>
            /// <para>接收卡片短信的手机号码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        /// <summary>
        /// <para>The code of the card message template. On the <a href="https://dysms.console.aliyun.com/domestic/card">Template Management</a> page of the <b>Card Messages</b> module in the console, select the code of an approved card message template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_70</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The code of the fallback digital message template. This parameter is required if you set <b>FallbackType</b> to <b>DIGITALSMS</b>.</para>
        /// <para>You can view the digital message template list on the <a href="https://dysms.console.aliyun.com/domestic/digit">Template Management</a> page of the <b>Digital Messages</b> module in the console.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DIGITAL_SMS_31359****</para>
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the fallback digital message template. This parameter is required if the digital message template specified by <b>DigitalTemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON value contains line breaks, follow the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;msg&quot;,&quot;xxxd&quot;}</para>
        /// </summary>
        [NameInMap("DigitalTemplateParam")]
        [Validation(Required=false)]
        public string DigitalTemplateParam { get; set; }

        /// <summary>
        /// <para>The fallback type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SMS</b>: Falls back to a text message for phone numbers that do not support card messages.</description></item>
        /// <item><description><b>DIGITALSMS</b>: Falls back to a digital message for phone numbers that do not support card messages.</description></item>
        /// <item><description><b>NONE</b>: No fallback is required.</description></item>
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
        /// <para>The ID reserved for the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38d76c9b-4a9a-4c89-afae-61fd8e0e****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The signature name. You can call the <a href="https://help.aliyun.com/document_detail/419282.html">QuerySmsSignList</a> operation to query the signatures applied for under the current account or view the signature list in the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service (SMS) console</a>.</para>
        /// <remarks>
        /// <para>The signature must be approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The code of the fallback text message template. This parameter is required if you set <b>FallbackType</b> to <b>SMS</b>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> operation to query the templates applied for under the current account or view the template list in the <a href="https://dysms.console.aliyun.com/domestic/text/template">SMS console</a>.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_48068****</para>
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the fallback text message template. This parameter is required if the text message template specified by <b>SmsTemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON value contains line breaks, follow the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;jifen&quot;:&quot;积分&quot;}</para>
        /// </summary>
        [NameInMap("SmsTemplateParam")]
        [Validation(Required=false)]
        public string SmsTemplateParam { get; set; }

        /// <summary>
        /// <para>The extension code of the MO message. An MO message is a message sent to the communications service provider to customize a service, perform a query, or handle other business. The message is charged at the standard rate of the carrier.</para>
        /// <remarks>
        /// <para>If you do not have such requirements, ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// <para>The code of the custom content template.</para>
        /// <para>The custom content is sent to the recipient as a text message template combined with a card parsing link. Log on to the <a href="https://dysms.console.aliyun.com/overview">SMS console</a>, choose <b>Domestic Messages</b> or <b>International/HK/MO/TW Messages</b>, and view the <b>Template Code</b> on the <b>Template Management</b> tab.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The template code must be added and approved. To send international or Hong Kong, Macao, or Taiwan messages, use an international or Hong Kong, Macao, or Taiwan message template.</description></item>
        /// <item><description>For example, if the selected text message template is &quot;You have a new message&quot; and the card parsing link is <c>1*.cn/2**d</c>, the final content is <c>You have a new message 1*.cn/2**d</c>. Test the message and control the word count before sending.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_2322****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the custom content template. This parameter is required if the message template specified by <b>TemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON value contains line breaks, follow the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;code&quot;: &quot;1111&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

    }

}
