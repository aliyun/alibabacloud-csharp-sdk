// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeStoresResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Stores")]
        [Validation(Required=false)]
        public DescribeStoresResponseBodyStores Stores { get; set; }
        public class DescribeStoresResponseBodyStores : TeaModel {
            [NameInMap("StoreInfo")]
            [Validation(Required=false)]
            public List<DescribeStoresResponseBodyStoresStoreInfo> StoreInfo { get; set; }
            public class DescribeStoresResponseBodyStoresStoreInfo : TeaModel {
                [NameInMap("Brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                [NameInMap("CompanyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Groups")]
                [Validation(Required=false)]
                public string Groups { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("StoreId")]
                [Validation(Required=false)]
                public string StoreId { get; set; }

                [NameInMap("StoreName")]
                [Validation(Required=false)]
                public string StoreName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
