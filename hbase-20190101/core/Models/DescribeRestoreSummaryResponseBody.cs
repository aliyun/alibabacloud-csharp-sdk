// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreSummaryResponseBody : TeaModel {
        [NameInMap("HasMoreRestoreRecord")]
        [Validation(Required=false)]
        public int? HasMoreRestoreRecord { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rescords")]
        [Validation(Required=false)]
        public DescribeRestoreSummaryResponseBodyRescords Rescords { get; set; }
        public class DescribeRestoreSummaryResponseBodyRescords : TeaModel {
            [NameInMap("Rescord")]
            [Validation(Required=false)]
            public List<DescribeRestoreSummaryResponseBodyRescordsRescord> Rescord { get; set; }
            public class DescribeRestoreSummaryResponseBodyRescordsRescord : TeaModel {
                public string BulkLoadProcess { get; set; }
                public string CreateTime { get; set; }
                public string FinishTime { get; set; }
                public string HfileRestoreProcess { get; set; }
                public string LogProcess { get; set; }
                public string RecordId { get; set; }
                public string SchemaProcess { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
