// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendSmsRequest : TeaModel {
        /// <summary>
        /// <para>The external transaction ID.</para>
        /// <remarks>
        /// <para>You can ignore this parameter if you do not have special requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abcdefgh</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recipient\&quot;s mobile number. The format varies based on the destination region:</para>
        /// <list type="bullet">
        /// <item><description><para>For messages to the Chinese mainland: A mobile number, with or without a country code. Valid prefixes are +, +86, 0086, and 86. Example: 1390000\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>For international messages or messages to Hong Kong, Macao, or Taiwan: Use the format [Country code][Mobile number]. Example: 852000012\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>To send a test message, bind a test mobile number in the <a href="https://dysms.console.aliyun.com/quickstart">console</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To send a message to multiple numbers, separate them with commas (,). You can specify up to 1,000 mobile numbers per request. Bulk sending may have higher latency than sending single messages. For time-sensitive messages such as verification codes, we recommend sending them individually.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbers { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature name.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/419282.html">QuerySmsSignList</a> API or view your list of signatures in the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>. You must use a signature that has been <b>approved</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>1\. If a verification code signature and a general-purpose signature share the same name, the general-purpose signature is used by default.</para>
        /// </description></item>
        /// <item><description><para>2\. The system uses the specified signature to send the message.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The upstream SMS extension code. An upstream SMS message is a message sent from a user to a service provider to subscribe to a service, make a query, or perform other tasks. Such messages are charged by the carrier at standard rates.</para>
        /// <remarks>
        /// <para>The system assigns a default extension code when a signature is created. Use this parameter to specify a different code. You can ignore this parameter if you do not have special requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90999</para>
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// <para>The code of the template.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> API or view your list of templates in the <a href="https://dysms.console.aliyun.com/domestic/text/template">Short Message Service console</a>. You must use the code of a template that has been <b>approved</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_15305****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The values for the template variables, specified as a <b>JSON string</b>. This parameter is required if the template contains variables. The JSON string must provide a value for each variable.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If the JSON string needs to include line breaks, format it according to standard JSON specifications.</para>
        /// </description></item>
        /// <item><description><para>For more information about template variable formatting, see <a href="https://help.aliyun.com/document_detail/463161.html">SMS template specifications</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;张三&quot;,&quot;number&quot;:&quot;1390000****&quot;}</para>
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

    }

}
