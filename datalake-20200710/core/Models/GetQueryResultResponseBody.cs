// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GetQueryResultResponseBody : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("JobCompleted")]
        [Validation(Required=false)]
        public bool? JobCompleted { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public long? Owner { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultTmpDb")]
        [Validation(Required=false)]
        public string ResultTmpDb { get; set; }

        [NameInMap("ResultTmpTable")]
        [Validation(Required=false)]
        public string ResultTmpTable { get; set; }

        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        [NameInMap("RowCountOverLimit")]
        [Validation(Required=false)]
        public bool? RowCountOverLimit { get; set; }

        [NameInMap("Rows")]
        [Validation(Required=false)]
        public string Rows { get; set; }

        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalBytesProcessed")]
        [Validation(Required=false)]
        public long? TotalBytesProcessed { get; set; }

    }

}
