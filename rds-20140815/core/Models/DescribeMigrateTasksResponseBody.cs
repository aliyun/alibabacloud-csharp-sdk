// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTasksResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMigrateTasksResponseBodyItems Items { get; set; }
        public class DescribeMigrateTasksResponseBodyItems : TeaModel {
            [NameInMap("MigrateTask")]
            [Validation(Required=false)]
            public List<DescribeMigrateTasksResponseBodyItemsMigrateTask> MigrateTask { get; set; }
            public class DescribeMigrateTasksResponseBodyItemsMigrateTask : TeaModel {
                public string EndTime { get; set; }
                public string Status { get; set; }
                public string Description { get; set; }
                public string CreateTime { get; set; }
                public string DBName { get; set; }
                public string BackupMode { get; set; }
                public string MigrateTaskId { get; set; }
                public string IsDBReplaced { get; set; }
            }
        };

    }

}
