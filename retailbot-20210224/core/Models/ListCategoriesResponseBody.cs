// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListCategoriesResponseBody : TeaModel {
        /// <summary>
        /// 知识类目集合
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<ListCategoriesResponseBodyCategories> Categories { get; set; }
        public class ListCategoriesResponseBodyCategories : TeaModel {
            /// <summary>
            /// 类目id
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// 类目名称
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// 子级类目集合
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<ListCategoriesResponseBodyCategoriesChildren> Children { get; set; }
            public class ListCategoriesResponseBodyCategoriesChildren : TeaModel {
                /// <summary>
                /// 类目id
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                /// <summary>
                /// 类目名称
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// 父类目id
                /// </summary>
                [NameInMap("ParentCategoryId")]
                [Validation(Required=false)]
                public long? ParentCategoryId { get; set; }

            }

            /// <summary>
            /// 父类目id
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

        }

        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功标示
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
