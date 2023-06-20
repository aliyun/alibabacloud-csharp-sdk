// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeDistributionProductsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DescribeDistributionProductsResponseBodyResults> Results { get; set; }
        public class DescribeDistributionProductsResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("FirstCategoryName")]
            [Validation(Required=false)]
            public string FirstCategoryName { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("SecondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            [NameInMap("SubmissionRadio")]
            [Validation(Required=false)]
            public string SubmissionRadio { get; set; }

            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            [NameInMap("SupplierUId")]
            [Validation(Required=false)]
            public string SupplierUId { get; set; }

            [NameInMap("TradeCount")]
            [Validation(Required=false)]
            public string TradeCount { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserCommentCount")]
            [Validation(Required=false)]
            public string UserCommentCount { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
