// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsRequest : TeaModel {
        /// <summary>
        /// <para>The code of the card SMS template. On the <b>Card SMS</b> <a href="https://dysms.console.aliyun.com/domestic/card">Template Management</a> page in the console, select the code of a card SMS template that has been <b>approved</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_3**5</para>
        /// </summary>
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the card SMS template. This parameter is required when the card SMS template specified by <b>CardTemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON contains line breaks, handle them based on the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;customurl&quot;:&quot;<a href="http://www.alibaba.com%22,%22dyncParams%22:%22%7B%22a%22:%22hello%22,%22b%22:%22world%22%7D%22%7D%5D">http://www.alibaba.com&quot;,&quot;dyncParams&quot;:&quot;{&quot;a&quot;:&quot;hello&quot;,&quot;b&quot;:&quot;world&quot;}&quot;}]</a></para>
        /// </summary>
        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The code of the digital SMS template used for fallback. This parameter is required when <b>FallbackType</b> is set to <b>DIGITALSMS</b> (fallback to digital SMS).</para>
        /// <para>You can view the list of digital SMS templates on the <b>Domestic Digital SMS</b> <a href="https://dysms.console.aliyun.com/domestic/digit">Template Management</a> page in the console.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DIGITAL_SMS_23408****</para>
        /// </summary>
        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the digital SMS template. This parameter is required when the fallback digital SMS template specified by <b>DigitalTemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON contains line breaks, handle them based on the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;a&quot;:1,&quot;b&quot;:2},{&quot;a&quot;:9,&quot;b&quot;:8}]</para>
        /// </summary>
        [NameInMap("DigitalTemplateParamJson")]
        [Validation(Required=false)]
        public string DigitalTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The fallback type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SMS</b>: Phone numbers that do not support card SMS messages fall back to text SMS messages.</description></item>
        /// <item><description><b>DIGITALSMS</b>: Phone numbers that do not support card SMS messages fall back to digital SMS messages.</description></item>
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
        /// <para>16545681783595370</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers that receive the SMS messages.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1390000****&quot;,&quot;1370000****&quot;]</para>
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        /// <summary>
        /// <para>The name of the SMS signature.
        /// You can call the <a href="https://help.aliyun.com/document_detail/419282.html">QuerySmsSignList</a> operation to query the signatures that have been submitted under the current account, or you can view the list of signatures in the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>.</para>
        /// <remarks>
        /// <para>The signature must be added and approved. The number of SMS signatures must be the same as the number of phone numbers, and the signatures must be in one-to-one correspondence with the phone numbers.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;阿里云&quot;,&quot;阿里巴巴&quot;]</para>
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        /// <summary>
        /// <para>The code of the text SMS template used for fallback. This parameter is required when <b>FallbackType</b> is set to <b>SMS</b> (fallback to text SMS).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> operation to query the templates that have been submitted under the current account, or you can view the list of templates in the <a href="https://dysms.console.aliyun.com/domestic/text/template">Short Message Service console</a>.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_23425****</para>
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the text SMS template. This parameter is required when the fallback text SMS template specified by <b>SmsTemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <para>If the JSON contains line breaks, handle them based on the standard JSON protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;a&quot;:1,&quot;b&quot;:2},{&quot;a&quot;:9,&quot;b&quot;:8}]</para>
        /// </summary>
        [NameInMap("SmsTemplateParamJson")]
        [Validation(Required=false)]
        public string SmsTemplateParamJson { get; set; }

        /// <summary>
        /// <para>The extension code of the MO (mobile-originated) SMS message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;6\&quot;,\&quot;6\&quot;]</para>
        /// </summary>
        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        /// <summary>
        /// <para>The code of the custom send content template.</para>
        /// <para>The custom content is sent to the terminal in the form of the selected text SMS template plus the card parsing link. You can log on to the <a href="https://dysms.console.aliyun.com/overview">Short Message Service console</a>, choose <b>Domestic Messages</b> or <b>International/Hong Kong, Macao, and Taiwan Messages</b>, and then view the <b>Template Code</b> on the <b>Template Management</b> page.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The template must be added and approved. To send international or Hong Kong, Macao, and Taiwan messages, use an international or Hong Kong, Macao, and Taiwan SMS template.</description></item>
        /// <item><description>For example, the selected text SMS template content is: You have a message to check; the card parsing link is: <c>1*.cn/2**d</c>. The final delivered content is: <c>You have a message to check 1*.cn/2**d</c>. Perform testing and control the number of characters before sending.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_20375****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values of the variables in the custom send content template. This parameter is required when the SMS template specified by <b>TemplateCode</b> contains variables.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the JSON contains line breaks, handle them based on the standard JSON protocol.</description></item>
        /// <item><description>The number of template variable values must be the same as the number of phone numbers and signatures, and they must be in one-to-one correspondence. This indicates that an SMS message with the corresponding signature is sent to the specified phone number, and the variable parameters in the SMS template are replaced with the corresponding values.</description></item>
        /// </list>
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
