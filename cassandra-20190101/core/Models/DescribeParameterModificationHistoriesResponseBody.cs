// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeParameterModificationHistoriesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Histories")]
        [Validation(Required=false)]
        public DescribeParameterModificationHistoriesResponseBodyHistories Histories { get; set; }
        public class DescribeParameterModificationHistoriesResponseBodyHistories : TeaModel {
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<DescribeParameterModificationHistoriesResponseBodyHistoriesHistory> History { get; set; }
            public class DescribeParameterModificationHistoriesResponseBodyHistoriesHistory : TeaModel {
                public long? Time { get; set; }
                public string OldValue { get; set; }
                public string Name { get; set; }
                public string NewValue { get; set; }
            }
        };

    }

}
