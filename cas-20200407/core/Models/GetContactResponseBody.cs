// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1352570</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@163.com">test@163.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address is verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EmailStatus")]
        [Validation(Required=false)]
        public int? EmailStatus { get; set; }

        /// <summary>
        /// <para>The ID card number of the contact. This parameter is required for the CFCA certificate brand and is not required for other brands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>142***************</para>
        /// </summary>
        [NameInMap("IdCard")]
        [Validation(Required=false)]
        public string IdCard { get; set; }

        /// <summary>
        /// <para>The phone number of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1510108****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Indicates whether the phone number is verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MobileStatus")]
        [Validation(Required=false)]
        public int? MobileStatus { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EECA10D5-BD0F-4EF1-B3EA-B4578E5C6F8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
