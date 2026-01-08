// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListInstagramPostsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInstagramPostsResponseBodyData> Data { get; set; }
        public class ListInstagramPostsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-30T15:53:01+08:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxxxx">https://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("FullPicture")]
            [Validation(Required=false)]
            public string FullPicture { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://qjck.oss-cn-shanghai.aliyuncs.com/xcx/2025-08-29/0bfa1c8d-d35f-2dd5-e082-7b00***ee9.jpg?x-oss-process=image/resize,m_lfit,w_1200">https://qjck.oss-cn-shanghai.aliyuncs.com/xcx/2025-08-29/0bfa1c8d-d35f-2dd5-e082-7b00***ee9.jpg?x-oss-process=image/resize,m_lfit,w_1200</a></para>
            /// </summary>
            [NameInMap("MediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxxxx">https://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("PermalinkUrl")]
            [Validation(Required=false)]
            public string PermalinkUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A***66411B2O</para>
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

    }

}
