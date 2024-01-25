// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeEslDeviceResponseBody : TeaModel {
        [NameInMap("EslDetails")]
        [Validation(Required=false)]
        public List<DescribeEslDeviceResponseBodyEslDetails> EslDetails { get; set; }
        public class DescribeEslDeviceResponseBodyEslDetails : TeaModel {
            [NameInMap("EslBarCode")]
            [Validation(Required=false)]
            public string EslBarCode { get; set; }

            [NameInMap("ItemBarCode")]
            [Validation(Required=false)]
            public long? ItemBarCode { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemShortTitle")]
            [Validation(Required=false)]
            public string ItemShortTitle { get; set; }

            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public string LastUpdateTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
