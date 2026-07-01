// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchSmsRequest : TeaModel {
        /// <summary>
        /// <para>An external business ID. It must be a string of fewer than 256 characters.</para>
        /// <remarks>
        /// <para>You can leave this parameter empty if you have no special requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abcdefg</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recipient phone numbers. Format:</para>
        /// <list type="bullet">
        /// <item><description><para>For domestic SMS: Phone numbers with or without a country code such as <c>+</c>, <c>+86</c>, <c>0086</c>, or <c>86</c>. Example: <c>1590000****</c>.</para>
        /// </description></item>
        /// <item><description><para>For international SMS: The country code followed by the phone number. Example: <c>852000012****</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For time-sensitive messages like verification codes, use the <a href="https://help.aliyun.com/document_detail/419273.html">SendSms</a> operation to send messages individually.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1590000****&quot;,&quot;1350000****&quot;]</para>
        /// </summary>
        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature names. The number of signatures must match the number of phone numbers.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/419282.html">QuerySmsSignList</a> operation or check the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a> to find approved signatures. You must use an approved signature.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The system uses the selected signature to send SMS messages.</description></item>
        /// </list>
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
        /// <para>A JSON array of MO SMS extension codes.</para>
        /// <remarks>
        /// <para>You can leave this parameter empty if you have no special requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;90999&quot;,&quot;90998&quot;]</para>
        /// </summary>
        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        /// <summary>
        /// <para>The message template code. You cannot use templates for domestic SMS and international SMS interchangeably.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> operation or check the <a href="https://dysms.console.aliyun.com/domestic/text/template">Short Message Service console</a> to find approved template codes. You must use an approved template code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_15255****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The actual values for the template variables. This parameter is required if the template contains variables.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The number of template variable sets must match the number of phone numbers and signatures. The elements in the PhoneNumberJson, SignNameJson, and TemplateParamJson arrays must correspond by index to ensure each message is sent with the correct signature and variable values.</para>
        /// </description></item>
        /// <item><description><para>If you need to include a line break in the JSON string, follow the standard JSON format.</para>
        /// </description></item>
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
