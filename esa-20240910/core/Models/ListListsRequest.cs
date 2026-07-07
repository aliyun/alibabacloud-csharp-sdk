// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListListsRequest : TeaModel {
        /// <summary>
        /// <para>The page number for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query parameters passed in JSON format, which contain various filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListLists</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListListsRequestQueryArgs QueryArgs { get; set; }
        public class ListListsRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>Specifies whether to sort the results in descending order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>The value used to fuzzy match list descriptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a custom list</para>
            /// </summary>
            [NameInMap("DescriptionLike")]
            [Validation(Required=false)]
            public string DescriptionLike { get; set; }

            /// <summary>
            /// <para>The value used to fuzzy match list IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000001</para>
            /// </summary>
            [NameInMap("IdLike")]
            [Validation(Required=false)]
            public string IdLike { get; set; }

            /// <summary>
            /// <para>The value used to fuzzy match list content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("ItemLike")]
            [Validation(Required=false)]
            public string ItemLike { get; set; }

            /// <summary>
            /// <para>The kind of the custom list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The value used to fuzzy match both list content and list names simultaneously.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("NameItemLike")]
            [Validation(Required=false)]
            public string NameItemLike { get; set; }

            /// <summary>
            /// <para>The value used to fuzzy match list names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>The column by which to sort the results.</para>
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
