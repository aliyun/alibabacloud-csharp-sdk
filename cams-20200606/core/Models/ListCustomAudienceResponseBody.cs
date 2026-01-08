// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListCustomAudienceResponseBody : TeaModel {
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
        public List<ListCustomAudienceResponseBodyData> Data { get; set; }
        public class ListCustomAudienceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>339**</para>
            /// </summary>
            [NameInMap("AdAccountId")]
            [Validation(Required=false)]
            public string AdAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1720356898</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>339**</para>
            /// </summary>
            [NameInMap("CustomAudienceId")]
            [Validation(Required=false)]
            public string CustomAudienceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom audience name</para>
            /// </summary>
            [NameInMap("CustomAudienceName")]
            [Validation(Required=false)]
            public string CustomAudienceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>239**</para>
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("TokenTotal")]
            [Validation(Required=false)]
            public long? TokenTotal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>excel</para>
            /// </summary>
            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
