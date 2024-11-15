// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappEmbedSignUpResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the call is successful.</description></item>
        /// <item><description>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of the WhatsApp Business accounts.</para>
        /// </summary>
        [NameInMap("Wabas")]
        [Validation(Required=false)]
        public List<ChatappEmbedSignUpResponseBodyWabas> Wabas { get; set; }
        public class ChatappEmbedSignUpResponseBodyWabas : TeaModel {
            /// <summary>
            /// <para>The review state of the WABA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VERIFIED</para>
            /// </summary>
            [NameInMap("AccountReviewStatus")]
            [Validation(Required=false)]
            public string AccountReviewStatus { get; set; }

            /// <summary>
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The ID of the WABA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2939933992*****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The namespace of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alals-lsslls-slslsos-slsl</para>
            /// </summary>
            [NameInMap("MessageTemplateNamespace")]
            [Validation(Required=false)]
            public string MessageTemplateNamespace { get; set; }

            /// <summary>
            /// <para>The name of the WABA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
