// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserRestrictedURLsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of restricted URLs on the current page. Each record contains a restricted URL and its unique identifier. If no restricted URLs are configured under the specified conditions, an empty array is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBrowserRestrictedURLsResponseBodyData> Data { get; set; }
        public class ListBrowserRestrictedURLsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the restricted URL record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ru-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("RestrictedURLId")]
            [Validation(Required=false)]
            public string RestrictedURLId { get; set; }

            /// <summary>
            /// <para>The URL address that is restricted from access.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The actual page number used in this query. This is the echoed value of the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The actual number of entries returned per page in this query. This is the echoed value of the PageSize request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate call records and troubleshoot issues. The example value is partially masked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4A13D91-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of restricted URL records that meet the filter conditions. This value is independent of the number of records returned on the current page and can be used with PageSize to calculate the total number of pages. If no records meet the conditions, 0 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
