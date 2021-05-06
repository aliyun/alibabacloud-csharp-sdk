// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeInclinedTablesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInclinedTablesResponseBodyItems Items { get; set; }
        public class DescribeInclinedTablesResponseBodyItems : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeInclinedTablesResponseBodyItemsTable> Table { get; set; }
            public class DescribeInclinedTablesResponseBodyItemsTable : TeaModel {
                public string Type { get; set; }
                public string Schema { get; set; }
                public long? Size { get; set; }
                public string Name { get; set; }
                public bool? IsIncline { get; set; }
            }
        };

    }

}
