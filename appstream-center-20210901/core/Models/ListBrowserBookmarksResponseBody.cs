// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserBookmarksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of bookmarks on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBrowserBookmarksResponseBodyData> Data { get; set; }
        public class ListBrowserBookmarksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bookmark folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Work</para>
            /// </summary>
            [NameInMap("BookmarkFolder")]
            [Validation(Required=false)]
            public string BookmarkFolder { get; set; }

            /// <summary>
            /// <para>The bookmark ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bm-0c7loey7fzjq****</para>
            /// </summary>
            [NameInMap("BookmarkId")]
            [Validation(Required=false)]
            public string BookmarkId { get; set; }

            /// <summary>
            /// <para>The bookmark name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("BookmarkName")]
            [Validation(Required=false)]
            public string BookmarkName { get; set; }

            /// <summary>
            /// <para>The bookmark URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("BookmarkURL")]
            [Validation(Required=false)]
            public string BookmarkURL { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0C2ED-95F2-1A37-9FC6-4A395179****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of bookmarks that meet the filtering conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
