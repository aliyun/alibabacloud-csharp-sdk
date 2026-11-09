// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserBookmarksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud browser group. You must specify either this parameter or BrowserInstanceGroupSetId, but not both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0c7loey7fzjq****</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the browser delivery group set. You must specify either this parameter or BrowserInstanceGroupId, but not both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupSetId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The keyword used for substring matching in bookmark names or URLs. The matching is case-insensitive for English characters. The keyword can be up to 1,024 characters in length after leading and trailing spaces are removed. If this parameter is not specified or contains only spaces, no filtering is applied. Special characters are matched literally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
