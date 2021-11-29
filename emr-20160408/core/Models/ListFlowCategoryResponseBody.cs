// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowCategoryResponseBody : TeaModel {
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public ListFlowCategoryResponseBodyCategories Categories { get; set; }
        public class ListFlowCategoryResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<ListFlowCategoryResponseBodyCategoriesCategory> Category { get; set; }
            public class ListFlowCategoryResponseBodyCategoriesCategory : TeaModel {
                public string CategoryType { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string ObjectId { get; set; }
                public string ObjectType { get; set; }
                public string ParentId { get; set; }
                public string ProjectId { get; set; }
                public string Type { get; set; }
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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
