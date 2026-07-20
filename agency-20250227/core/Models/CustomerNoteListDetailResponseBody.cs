// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class CustomerNoteListDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details returned by the POP API when RAM permissions are missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CustomerNoteListDetailResponseBodyData Data { get; set; }
        public class CustomerNoteListDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AI parsing result (JSON string).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;触达日期&quot;:&quot;2026-07-17 10:00:01&quot;}</para>
            /// </summary>
            [NameInMap("AiResult")]
            [Validation(Required=false)]
            public string AiResult { get; set; }

            /// <summary>
            /// <para>The attachment list.</para>
            /// </summary>
            [NameInMap("Attachment")]
            [Validation(Required=false)]
            public List<CustomerNoteListDetailResponseBodyDataAttachment> Attachment { get; set; }
            public class CustomerNoteListDetailResponseBodyDataAttachment : TeaModel {
                /// <summary>
                /// <para>The attachment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The attachment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>课程培训</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The attachment signature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hF2UrEMc4XWy990sh9LGM0+ScI8=</para>
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The attachment size, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111222121</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The attachment type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13833333333</para>
            /// </summary>
            [NameInMap("ContactInformation")]
            [Validation(Required=false)]
            public string ContactInformation { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The UID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>291688841144601701</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public long? Creator { get; set; }

            /// <summary>
            /// <para>The username of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The customer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXXX有限公司</para>
            /// </summary>
            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <para>The customer UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1271202085096245</para>
            /// </summary>
            [NameInMap("CustomerUid")]
            [Validation(Required=false)]
            public long? CustomerUid { get; set; }

            /// <summary>
            /// <para>The creation time (yyyy-MM-dd HH:mm:ss).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07 10:27:46</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The note content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小记内容</para>
            /// </summary>
            [NameInMap("NoteContent")]
            [Validation(Required=false)]
            public string NoteContent { get; set; }

            /// <summary>
            /// <para>The note ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620737</para>
            /// </summary>
            [NameInMap("NoteId")]
            [Validation(Required=false)]
            public long? NoteId { get; set; }

            /// <summary>
            /// <para>The note type (CUSTOMER).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOMER</para>
            /// </summary>
            [NameInMap("NoteType")]
            [Validation(Required=false)]
            public string NoteType { get; set; }

            /// <summary>
            /// <para>The note type label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户</para>
            /// </summary>
            [NameInMap("NoteTypeLabel")]
            [Validation(Required=false)]
            public string NoteTypeLabel { get; set; }

            /// <summary>
            /// <para>The touch date (timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1784266662000</para>
            /// </summary>
            [NameInMap("TouchDate")]
            [Validation(Required=false)]
            public string TouchDate { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the POP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The prompt message, same as Message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
