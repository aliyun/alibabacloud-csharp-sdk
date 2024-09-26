// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListCategoryResponseBody : TeaModel {
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<ListCategoryResponseBodyCategories> Categories { get; set; }
        public class ListCategoryResponseBodyCategories : TeaModel {
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>231001028593</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9C5F8186-2D22-433E-9545-606D344F30B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
