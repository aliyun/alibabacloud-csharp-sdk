// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeCategoryResponseBody : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public DescribeCategoryResponseBodyCategory Category { get; set; }
        public class DescribeCategoryResponseBodyCategory : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
