// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateContactRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The mapping of instant messaging (IM) user IDs. Multiple IM tools are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dingtalk&quot;:&quot;abc123&quot;,&quot;wechat&quot;:&quot;def456&quot;}</para>
        /// </summary>
        [NameInMap("imUserIds")]
        [Validation(Required=false)]
        public Dictionary<string, string> ImUserIds { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the contact. Currently, only mobile phone numbers in China are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150123456789</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The country code of the mobile phone number, which is typically +86 for China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+86</para>
        /// </summary>
        [NameInMap("phoneCode")]
        [Validation(Required=false)]
        public string PhoneCode { get; set; }

    }

}
