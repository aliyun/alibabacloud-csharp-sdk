// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the call is successful.</para>
        /// </description></item>
        /// <item><description><para>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message templates.</para>
        /// </summary>
        [NameInMap("ListTemplate")]
        [Validation(Required=false)]
        public List<ListChatappTemplateResponseBodyListTemplate> ListTemplate { get; set; }
        public class ListChatappTemplateResponseBodyListTemplate : TeaModel {
            /// <summary>
            /// <para>The review state of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: The template is approved.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: The template is rejected.</para>
            /// </description></item>
            /// <item><description><para><b>auditing</b>: The template is being reviewed.</para>
            /// </description></item>
            /// <item><description><para><b>unaudit</b>: The review is suspended.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The category of the WhatsApp message template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UTILITY</b></para>
            /// </description></item>
            /// <item><description><para><b>MARKETING</b></para>
            /// </description></item>
            /// <item><description><para><b>AUTHENTICATION</b></para>
            /// </description></item>
            /// </list>
            /// <para>The category of the Viber template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>text</b>: template that contains only text</para>
            /// </description></item>
            /// <item><description><para><b>image</b>: template that contains only images</para>
            /// </description></item>
            /// <item><description><para><b>text_image_button</b>: template that contains text, images, and buttons</para>
            /// </description></item>
            /// <item><description><para><b>text_button</b>: template that contains text and buttons</para>
            /// </description></item>
            /// <item><description><para><b>document</b>: template that contains only documents</para>
            /// </description></item>
            /// <item><description><para><b>video</b>: template that contains only videos</para>
            /// </description></item>
            /// <item><description><para><b>text_video</b>: template that contains text and videos</para>
            /// </description></item>
            /// <item><description><para><b>text_video_button</b>: template that contains text, videos, and buttons</para>
            /// </description></item>
            /// <item><description><para><b>text_image</b>: template that contains text and images</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UTILITY</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711006633000</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The reason why the template was rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The code of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>744c4b5c79c9432497a075bdfca3****</para>
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

            /// <summary>
            /// <para>The type of the template. Valid values: WHATSAPP and VIBER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WHATSAPP</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

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
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
