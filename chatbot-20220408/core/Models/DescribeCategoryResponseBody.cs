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
            /// <para>The ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000049006</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>类目名称</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent category. A value of -1 indicates the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

            /// <summary>
            /// <para>The status of the category. Valid values: 0 (Normal) or -1 (Deleted).</para>
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
