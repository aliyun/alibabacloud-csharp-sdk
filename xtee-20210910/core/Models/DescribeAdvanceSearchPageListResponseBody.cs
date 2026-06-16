// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAdvanceSearchPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeAdvanceSearchPageListResponseBodyResultObject ResultObject { get; set; }
        public class DescribeAdvanceSearchPageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The returned data object.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            /// <summary>
            /// <para>The table header.</para>
            /// </summary>
            [NameInMap("header")]
            [Validation(Required=false)]
            public List<DescribeAdvanceSearchPageListResponseBodyResultObjectHeader> Header { get; set; }
            public class DescribeAdvanceSearchPageListResponseBodyResultObjectHeader : TeaModel {
                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("fieldTitle")]
                [Validation(Required=false)]
                public string FieldTitle { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is displayed by default. This field is included in the response only and is not used as a request parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The field is displayed by default.</description></item>
                /// <item><description>false: The field is not displayed by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page in the response. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37</para>
            /// </summary>
            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public long? TotalItem { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

    }

}
