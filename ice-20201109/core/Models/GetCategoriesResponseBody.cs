// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCategoriesResponseBody : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public GetCategoriesResponseBodyCategory Category { get; set; }
        public class GetCategoriesResponseBodyCategory : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCategories")]
        [Validation(Required=false)]
        public GetCategoriesResponseBodySubCategories SubCategories { get; set; }
        public class GetCategoriesResponseBodySubCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetCategoriesResponseBodySubCategoriesCategory> Category { get; set; }
            public class GetCategoriesResponseBodySubCategoriesCategory : TeaModel {
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("SubTotal")]
                [Validation(Required=false)]
                public long? SubTotal { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("SubTotal")]
        [Validation(Required=false)]
        public long? SubTotal { get; set; }

    }

}
