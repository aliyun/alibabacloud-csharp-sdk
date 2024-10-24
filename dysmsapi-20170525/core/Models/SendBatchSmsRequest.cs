// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchSmsRequest : TeaModel {
        /// <summary>
        /// <para>The extension field of the external record. The value is a string that contains no more than 256 characters.</para>
        /// <remarks>
        /// <para>The parameter is optional.</para>
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
        /// <para>The mobile number of the recipient. Format:</para>
        /// <list type="bullet">
        /// <item><description>Message delivery to the Chinese mainland: +/+86/0086/86 or an 11-digit mobile number without a prefix. Example: 1590000\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>Message delivery to countries or regions outside the Chinese mainland: Dialing code + Mobile number. Example: 852000012\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>We recommend that you call the SendSms operation to send verification codes.</para>
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
        /// <para>The signature.</para>
        /// <para>Log on to the Alibaba Cloud SMS console. In the left-side navigation pane, click <b>Go Globe</b> or <b>Go China</b>. You can view the signature in the <b>Signature</b> column on the <b>Signatures</b> tab.</para>
        /// <remarks>
        /// <para>The signatures must be approved and correspond to the mobile numbers in sequence.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Aliyun&quot;,&quot;Alibaba&quot;]</para>
        /// </summary>
        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        /// <summary>
        /// <para>The extension code of the MO message. Format: JSON array.</para>
        /// <remarks>
        /// <para>The parameter is optional.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;90999&quot;,&quot;90998&quot;]</para>
        /// </summary>
        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// <para>Log on to the Alibaba Cloud SMS console. In the left-side navigation pane, click <b>Go Globe</b> or <b>Go China</b>. You can view the message template in the <b>Template Code</b> column on the <b>Message Templates</b> tab.</para>
        /// <remarks>
        /// <para>The message templates must be created on the Go Globe page and approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_15255****</para>
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
