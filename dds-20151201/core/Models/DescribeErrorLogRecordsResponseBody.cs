// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeErrorLogRecordsResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeErrorLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeErrorLogRecordsResponseBodyItemsLogRecords : TeaModel {
                public string ConnInfo { get; set; }
                public string CreateTime { get; set; }
                public string Category { get; set; }
                public string Content { get; set; }
                public int? Id { get; set; }
            }
        };

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

    }

}
