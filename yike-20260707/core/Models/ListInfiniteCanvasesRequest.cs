// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListInfiniteCanvasesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword for querying site monitoring tasks. Supports fuzzy match based on task name or task address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2_</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

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
        /// <para>The sort field and sort order. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>utcCreate:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort direction.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: Ascending order.</description></item>
        /// <item><description>Desc: Descending order.</description></item>
        /// </list>
        /// <para>Default value: Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
