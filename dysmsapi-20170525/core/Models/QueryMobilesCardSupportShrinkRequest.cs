// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryMobilesCardSupportShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The encryption method for the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SHA1: SHA1 encryption.</description></item>
        /// <item><description>NORMAL: no encryption. The phone number is transmitted in plaintext.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The list of phone numbers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public string MobilesShrink { get; set; }

        /// <summary>
        /// <para>The code of the card SMS template. To view the code, log on to the console and choose <b>Domestic Messages</b> &gt; <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a>.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_2****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
