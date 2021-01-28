// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            [NameInMap("BackupJobID")]
            [Validation(Required=false)]
            public int? BackupJobID { get; set; }

            [NameInMap("BackupProgressStatus")]
            [Validation(Required=false)]
            public string BackupProgressStatus { get; set; }

            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

        }

    }

}
