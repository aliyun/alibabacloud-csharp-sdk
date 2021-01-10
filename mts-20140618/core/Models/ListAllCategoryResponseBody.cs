// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
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
                public string CateName { get; set; }
                public string ParentId { get; set; }
                public string CateId { get; set; }
                public string Level { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
