// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetInfiniteCanvasResponseBody : TeaModel {
        /// <summary>
        /// <para>The infinite canvas details.</para>
        /// </summary>
        [NameInMap("InfiniteCanvas")]
        [Validation(Required=false)]
        public GetInfiniteCanvasResponseBodyInfiniteCanvas InfiniteCanvas { get; set; }
        public class GetInfiniteCanvasResponseBodyInfiniteCanvas : TeaModel {
            /// <summary>
            /// <para>The ID of the infinite canvas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>canvas_gesad*</para>
            /// </summary>
            [NameInMap("CanvasId")]
            [Validation(Required=false)]
            public string CanvasId { get; set; }

            /// <summary>
            /// <para>The cover URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://*uncs.com/cover.png</para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01T08:42:16Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01T08:42:16Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://*uncs.com/cover.png</para>
            /// </summary>
            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            /// <summary>
            /// <para>The title of the infinite canvas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test infinite canvas</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
