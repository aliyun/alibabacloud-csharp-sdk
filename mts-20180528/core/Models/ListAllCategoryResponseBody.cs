// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class ListAllCategoryResponseBody : TeaModel {
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public ListAllCategoryResponseBodyCategoryList CategoryList { get; set; }
        public class ListAllCategoryResponseBodyCategoryList : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<ListAllCategoryResponseBodyCategoryListCategory> Category { get; set; }
            public class ListAllCategoryResponseBodyCategoryListCategory : TeaModel {
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public string CateId { get; set; }

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
