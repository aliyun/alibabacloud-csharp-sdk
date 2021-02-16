// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLLogRecordsResponseBody : TeaModel {
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSQLLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLLogRecord")]
            [Validation(Required=false)]
            public List<DescribeSQLLogRecordsResponseBodyItemsSQLLogRecord> SQLLogRecord { get; set; }
            public class DescribeSQLLogRecordsResponseBodyItemsSQLLogRecord : TeaModel {
                public string HostAddress { get; set; }
                public string SQLText { get; set; }
                public long? UpdateRows { get; set; }
                public string State { get; set; }
                public int? ThreadID { get; set; }
                public string OriginTime { get; set; }
                public string InsName { get; set; }
                public long? ScanRows { get; set; }
                public long? Consume { get; set; }
                public string DBName { get; set; }
                public string ExecuteTime { get; set; }
                public string Vip { get; set; }
                public string AccountName { get; set; }
                public string SqlType { get; set; }
            }
        };

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("Finish")]
        [Validation(Required=false)]
        public string Finish { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("PagingID")]
        [Validation(Required=false)]
        public string PagingID { get; set; }

    }

}
