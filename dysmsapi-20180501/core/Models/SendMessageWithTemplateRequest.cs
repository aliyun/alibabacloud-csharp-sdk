// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5739</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The signature. To query the signature, log on to the <a href="https://sms-intl.console.aliyun.com/overview">Short Message Service (SMS) console</a> and navigate to the <b>Signatures</b> tab of the <b>Go China</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alicloud321</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The extension code of the MO message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90999</para>
        /// </summary>
        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// <para>The code of the message template. To query the code, log on to the <a href="https://sms-intl.console.aliyun.com/overview">SMS console</a> and navigate to the <b>Templates</b> tab of the <b>Go China</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The value of the variable in the message template. If a variable exists in the template, the parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;1234&quot;,&quot;product&quot;:&quot;ytx&quot;}</para>
        /// </summary>
        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

        /// <summary>
        /// <para>The mobile phone number to which the message is sent. You must add the country code to the beginning of the mobile phone number. Example: 861503871\<em>\</em>\<em>\</em>.</para>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/sms/product-overview/dialing-codes?spm=a2c63.p38356.0.0.367279cbwQFoeM">Dialing codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861503871****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <para>The validity period of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ValidityPeriod")]
        [Validation(Required=false)]
        public long? ValidityPeriod { get; set; }

    }

}
