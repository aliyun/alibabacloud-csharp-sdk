// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class QueryMarketCategoriesResponseBody : TeaModel {
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public QueryMarketCategoriesResponseBodyCategories Categories { get; set; }
        public class QueryMarketCategoriesResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<QueryMarketCategoriesResponseBodyCategoriesCategory> Category { get; set; }
            public class QueryMarketCategoriesResponseBodyCategoriesCategory : TeaModel {
                public string CategoryCode { get; set; }
                public string CategoryName { get; set; }
                public QueryMarketCategoriesResponseBodyCategoriesCategoryChildCategories ChildCategories { get; set; }
                public class QueryMarketCategoriesResponseBodyCategoriesCategoryChildCategories : TeaModel {
                    [NameInMap("ChildCategory")]
                    [Validation(Required=false)]
                    public List<QueryMarketCategoriesResponseBodyCategoriesCategoryChildCategoriesChildCategory> ChildCategory { get; set; }
                    public class QueryMarketCategoriesResponseBodyCategoriesCategoryChildCategoriesChildCategory : TeaModel {
                        [NameInMap("CategoryCode")]
                        [Validation(Required=false)]
                        public string CategoryCode { get; set; }

                        [NameInMap("CategoryName")]
                        [Validation(Required=false)]
                        public string CategoryName { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                }
                public long? Id { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
