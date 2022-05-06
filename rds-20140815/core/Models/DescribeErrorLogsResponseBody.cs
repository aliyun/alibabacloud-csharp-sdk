// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeErrorLogsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogsResponseBodyItems : TeaModel {
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public List<DescribeErrorLogsResponseBodyItemsErrorLog> ErrorLog { get; set; }
            public class DescribeErrorLogsResponseBodyItemsErrorLog : TeaModel {
                public string CreateTime { get; set; }
                public string ErrorInfo { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
