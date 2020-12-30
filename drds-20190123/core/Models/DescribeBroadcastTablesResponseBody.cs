// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBroadcastTablesResponseBody : TeaModel {
        [NameInMap("IsShard")]
        [Validation(Required=false)]
        public bool? IsShard { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeBroadcastTablesResponseBodyList> List { get; set; }
        public class DescribeBroadcastTablesResponseBodyList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }

            [NameInMap("Broadcast")]
            [Validation(Required=false)]
            public bool? Broadcast { get; set; }

            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public int? DbInstType { get; set; }

            [NameInMap("BroadcastType")]
            [Validation(Required=false)]
            public string BroadcastType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
