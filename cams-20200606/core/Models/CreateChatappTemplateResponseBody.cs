// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateCode&quot;: &quot;****4b5c79c9432497a075bdfca36bf5&quot;，&quot;templateName&quot;: &quot;hello_whatsapp&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateChatappTemplateResponseBodyData Data { get; set; }
        public class CreateChatappTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The code of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMS_232907****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The name of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello_whatsapp</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
