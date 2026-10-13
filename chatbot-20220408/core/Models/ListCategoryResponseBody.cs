// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of categories.</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<ListCategoryResponseBodyCategories> Categories { get; set; }
        public class ListCategoryResponseBodyCategories : TeaModel {
            /// <summary>
            /// <para>The business code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bizcode123</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231001028593</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CategoryName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parent category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

            /// <summary>
            /// <para>The category status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: Deleted but not published.</description></item>
            /// <item><description>0: Normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C5F8186-2D22-433E-9545-606D344F30B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
