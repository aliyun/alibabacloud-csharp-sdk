// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobDetailResponseBody : TeaModel {
        [NameInMap("DBTaskSQLJobDetailList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList> DBTaskSQLJobDetailList { get; set; }
        public class ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList : TeaModel {
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            [NameInMap("CurrentSql")]
            [Validation(Required=false)]
            public string CurrentSql { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            [NameInMap("JobDetailId")]
            [Validation(Required=false)]
            public long? JobDetailId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimeDelay")]
            [Validation(Required=false)]
            public long? TimeDelay { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
