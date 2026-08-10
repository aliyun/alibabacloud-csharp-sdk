// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListInfiniteCanvasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of infinite canvases.</para>
        /// </summary>
        [NameInMap("CanvasList")]
        [Validation(Required=false)]
        public List<ListInfiniteCanvasesResponseBodyCanvasList> CanvasList { get; set; }
        public class ListInfiniteCanvasesResponseBodyCanvasList : TeaModel {
            /// <summary>
            /// <para>The ID of the infinite canvas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>canvas_xxx</para>
            /// </summary>
            [NameInMap("CanvasId")]
            [Validation(Required=false)]
            public string CanvasId { get; set; }

            /// <summary>
            /// <para>The cover URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/cover.png">http://example.com/cover.png</a></para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The creation time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-26T10:21:17Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-18T10:03:56Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The thumbnail height, in px.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/thumbnail2.png">http://example.com/thumbnail2.png</a></para>
            /// </summary>
            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            /// <summary>
            /// <para>The title of the infinite canvas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of infinite canvases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
