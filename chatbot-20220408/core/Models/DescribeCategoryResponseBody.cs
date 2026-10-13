// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The category information.</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public DescribeCategoryResponseBodyCategory Category { get; set; }
        public class DescribeCategoryResponseBodyCategory : TeaModel {
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
            /// <para>30000049006</para>
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
            /// <para>The parent category ID. Default value: -1, which indicates the root directory.</para>
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
            /// <item><description>-1: deleted and unpublished.</description></item>
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
        /// <para>2B0304FD-3804-5C06-9A83-77F5523664AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
