// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListUserMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code returned by the service. SUCCESS indicates success; otherwise, it indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>外部userId映射关系不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of user message query results</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListUserMessageResponseBodyResult> Result { get; set; }
        public class ListUserMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Message text</para>
            /// 
            /// <b>Example:</b>
            /// <para>哈哈哈</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Device name</para>
            /// 
            /// <b>Example:</b>
            /// <para>卧室的小芳</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>Time when the message was sent</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-27 14:06:27.000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Message ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Device Image</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xx">http://xx</a></para>
            /// </summary>
            [NameInMap("Pic")]
            [Validation(Required=false)]
            public string Pic { get; set; }

            /// <summary>
            /// <para>Message source: app or box</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Source Device ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>AF188<b>065EE4B</b>DD68CE**951D84D4</para>
            /// </summary>
            [NameInMap("SourceUuid")]
            [Validation(Required=false)]
            public string SourceUuid { get; set; }

            /// <summary>
            /// <para>Message status: 0 indicates unread, and 1 indicates read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Currently only audio is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Audio message link</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xx">http://xx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
