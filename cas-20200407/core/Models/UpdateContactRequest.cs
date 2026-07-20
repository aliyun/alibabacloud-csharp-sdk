// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateContactRequest : TeaModel {
        /// <summary>
        /// <para>The contact ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1397591</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@136.com">test@136.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The ID card number of the contact. This parameter is required for the CFCA certificate brand and is not required for other brands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>142***************</para>
        /// </summary>
        [NameInMap("Idcard")]
        [Validation(Required=false)]
        public string Idcard { get; set; }

        /// <summary>
        /// <para>The phone number of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1510108***</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The name of the certificate contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The webhook URLs of DingTalk, WeCom, or Lark chatbots. The value is a string in list format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;<a href="https://open.feishu.cn/open-apis/bot/v2/hook/dc1aa9b9-47cd-4b34-91ef-73c1034208e5%5C%5C%22%5D">https://open.feishu.cn/open-apis/bot/v2/hook/dc1aa9b9-47cd-4b34-91ef-73c1034208e5\\&quot;]</a></para>
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
