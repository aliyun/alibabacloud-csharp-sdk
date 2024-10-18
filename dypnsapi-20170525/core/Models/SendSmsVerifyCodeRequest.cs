// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class SendSmsVerifyCodeRequest : TeaModel {
        /// <summary>
        /// <para>The length of the verification code. Default value: 4. Valid values: 4 to 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CodeLength")]
        [Validation(Required=false)]
        public long? CodeLength { get; set; }

        /// <summary>
        /// <para>The type of the generated verification code. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: digits only</description></item>
        /// <item><description>2: uppercase letters only</description></item>
        /// <item><description>3: lowercase letters only</description></item>
        /// <item><description>4: uppercase and lowercase letters</description></item>
        /// <item><description>5: digits and uppercase letters</description></item>
        /// <item><description>6: digits and lowercase letters</description></item>
        /// <item><description>7: digits and uppercase and lowercase letters</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public long? CodeType { get; set; }

        /// <summary>
        /// <para>The country code of the phone number. SMS verification codes can be sent only by using phone numbers in the Chinese mainland. Default value: 86.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>Specifies how to handle the verification codes received earlier in a case where verification codes are sent to the same phone number for the same scenario within the validity period.</para>
        /// <list type="bullet">
        /// <item><description>1 (default): The latest verification code overwrites the verification codes received earlier. In this case, verification codes received earlier expire.</description></item>
        /// <item><description>2: Verification codes within their validity period are valid and can be used for verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DuplicatePolicy")]
        [Validation(Required=false)]
        public long? DuplicatePolicy { get; set; }

        /// <summary>
        /// <para>The time interval. Unit: seconds. Default value: 60. This parameter specifies how often you can send a verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12358794Aqzaq</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86130****0000</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a verification code.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReturnVerifyCode")]
        [Validation(Required=false)]
        public bool? ReturnVerifyCode { get; set; }

        /// <summary>
        /// <para>The verification service name. If this parameter is not specified, the default service is used. The name can be up to 20 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// <para>The signature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun Test</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The extension code of the upstream text message. Upstream text messages are text messages sent to the communication service provider. Upstream text messages are used to customize a service, complete an inquiry, or send a request. You are charged for sending upstream text messages based on the billing standards of the service provider.</para>
        /// <remarks>
        /// <para> The extension code is automatically generated by the system when the signature is generated. You do not need to specify the extension code. You can skip this parameter based on your business requirements. If you want to use custom extension codes, contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1213123</para>
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// <para>The code of the text message template.</para>
        /// <para>Log on to the <a href="https://dysms.console.aliyun.com/dysms.htm?spm=5176.12818093.categories-n-products.ddysms.3b2816d0xml2NA#/overview">SMS console</a>. In the left-side navigation pane, click <b>Go China</b> or <b>Go Globe</b>. You can view the text message template code in the <b>Template Code</b> column on the <b>Message Templates</b> tab.</para>
        /// <remarks>
        /// <para> The text message templates must be created on the Go Globe page and approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>azsq_*****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The value of the variable in the text message template. The verification code is replaced with &quot;##code##&quot;.</para>
        /// <para>Example 1: For a system-defined template that contains variables, if the template content is &quot;Your verification code is ${code} and valid for 5 minutes. Do not disclose the verification code to others.&quot;, specify the value of this parameter as {&quot;code&quot;:&quot;##code##&quot;}</para>
        /// <para>Example 2: For a custom template, if the template content is ${content}, specify the value of this parameter as {&quot;content&quot;:&quot;Your verification code is ##code## and must be used within 5 minutes.&quot;}.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If line breaks are required in JSON-formatted data, they must meet the relevant requirements that are specified in the standard JSON protocol.</para>
        /// </description></item>
        /// <item><description><para>For more information about template variables, see <a href="https://help.aliyun.com/document_detail/108253.html">SMS template specifications</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;##code##&quot;}</para>
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

        /// <summary>
        /// <para>The validity period of the verification code. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public long? ValidTime { get; set; }

    }

}
