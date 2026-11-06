// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            [NameInMap("AbnormalDataIngestionCount")]
            [Validation(Required=false)]
            public int? AbnormalDataIngestionCount { get; set; }

            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public long? ActiveTime { get; set; }

            [NameInMap("AllowAddDataIngestion")]
            [Validation(Required=false)]
            public bool? AllowAddDataIngestion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public bool? DataIngestionStatus { get; set; }

            [NameInMap("EnabledDataIngestionCount")]
            [Validation(Required=false)]
            public int? EnabledDataIngestionCount { get; set; }

            [NameInMap("ProductAlias")]
            [Validation(Required=false)]
            public string ProductAlias { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("TotalDataIngestionCount")]
            [Validation(Required=false)]
            public int? TotalDataIngestionCount { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
