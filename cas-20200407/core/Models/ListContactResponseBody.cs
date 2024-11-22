// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The contacts.</para>
        /// </summary>
        [NameInMap("ContactList")]
        [Validation(Required=false)]
        public List<ListContactResponseBodyContactList> ContactList { get; set; }
        public class ListContactResponseBodyContactList : TeaModel {
            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>519580</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>The email address of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address passed the verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public int? EmailStatus { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****8888</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>Indicates whether the phone number was verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MobileStatus")]
            [Validation(Required=false)]
            public int? MobileStatus { get; set; }

            /// <summary>
            /// <para>The name of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ty-yaoyue.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The webhook URL of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;<a href="https://open.feishu.cn/open-apis/bot/v2/hook/XXX%5C%5C%22,%5C%5C%22https://oapi.dingtalk.com/robot/send?access_token=XXX%5C%5C%22,%5C%5C%22https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=XXX%5C%5C%22%5D">https://open.feishu.cn/open-apis/bot/v2/hook/XXX\\&quot;,\\&quot;https://oapi.dingtalk.com/robot/send?access_token=XXX\\&quot;,\\&quot;https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=XXX\\&quot;]</a></para>
            /// </summary>
            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public string Webhooks { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The keyword used in the fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of certificates per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
