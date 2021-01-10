// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetCategoryListResponseBody : TeaModel {
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public GetCategoryListResponseBodyCategoryList CategoryList { get; set; }
        public class GetCategoryListResponseBodyCategoryList : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetCategoryListResponseBodyCategoryListCategory> Category { get; set; }
            public class GetCategoryListResponseBodyCategoryListCategory : TeaModel {
                public long? CategoryId { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
