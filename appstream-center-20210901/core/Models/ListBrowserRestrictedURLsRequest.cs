// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserRestrictedURLsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the browser delivery group. You must specify either this parameter or BrowserInstanceGroupSetId, but not both. If you specify this parameter, the restricted URLs configured for the delivery group are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-3jm9d0abc00example</para>
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
        /// <para>The keyword used to filter access control URLs by using a contains match. The match is case-insensitive for English characters. The keyword can be up to 1,024 characters in length after leading and trailing spaces are removed. If you do not specify this parameter or specify only spaces, no filtering is performed. Special characters are matched literally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number during paging. Default value: 0. If the value is less than 1, such as 0, the first page is returned. If the value is less than 0, a parameter error is returned. Set this parameter to 1 or greater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page during paging. Valid values: 1 to 200. Default value: 200. If the value is less than or equal to 0 or greater than 200, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
