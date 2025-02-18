// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListListsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query arguments in the JSON format, which contain filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListLists</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListListsRequestQueryArgs QueryArgs { get; set; }
        public class ListListsRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>Specifies whether to sort the returned data in descending order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>The list description for fuzzy search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a custom list</para>
            /// </summary>
            [NameInMap("DescriptionLike")]
            [Validation(Required=false)]
            public string DescriptionLike { get; set; }

            /// <summary>
            /// <para>The list ID for fuzzy search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000001</para>
            /// </summary>
            [NameInMap("IdLike")]
            [Validation(Required=false)]
            public string IdLike { get; set; }

            /// <summary>
            /// <para>The list content for fuzzy search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("ItemLike")]
            [Validation(Required=false)]
            public string ItemLike { get; set; }

            /// <summary>
            /// <para>The type of the custom list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The list name and content for fuzzy search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("NameItemLike")]
            [Validation(Required=false)]
            public string NameItemLike { get; set; }

            /// <summary>
            /// <para>The list name for fuzzy search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>The column by which you want to sort the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

        }

    }

}
