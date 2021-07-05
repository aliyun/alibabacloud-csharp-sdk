// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTasksForSQLServerResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMigrateTasksForSQLServerResponseBodyItems Items { get; set; }
        public class DescribeMigrateTasksForSQLServerResponseBodyItems : TeaModel {
            [NameInMap("MigrateTask")]
            [Validation(Required=false)]
            public List<DescribeMigrateTasksForSQLServerResponseBodyItemsMigrateTask> MigrateTask { get; set; }
            public class DescribeMigrateTasksForSQLServerResponseBodyItemsMigrateTask : TeaModel {
                public string MigrateIaskId { get; set; }
                public string EndTime { get; set; }
                public string Status { get; set; }
                public string TaskType { get; set; }
                public string CreateTime { get; set; }
                public string DBName { get; set; }
                public string IsDBReplaced { get; set; }
                public string Desc { get; set; }
            }
        };

    }

}
