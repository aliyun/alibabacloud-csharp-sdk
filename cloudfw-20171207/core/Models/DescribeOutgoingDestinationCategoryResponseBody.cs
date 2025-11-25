// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationCategoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C1ED80BC-FFC8-57DB-8151-705DC31****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationCategoryResponseBodyTypeList> TypeList { get; set; }
        public class DescribeOutgoingDestinationCategoryResponseBodyTypeList : TeaModel {
            [NameInMap("CategoryList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationCategoryResponseBodyTypeListCategoryList> CategoryList { get; set; }
            public class DescribeOutgoingDestinationCategoryResponseBodyTypeListCategoryList : TeaModel {
                [NameInMap("CategoryDescribe")]
                [Validation(Required=false)]
                public string CategoryDescribe { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AliYun</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Trusted</para>
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

            }

            [NameInMap("TypeDescribe")]
            [Validation(Required=false)]
            public string TypeDescribe { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("TypeId")]
            [Validation(Required=false)]
            public string TypeId { get; set; }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
