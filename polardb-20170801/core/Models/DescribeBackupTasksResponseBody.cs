// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyItems Items { get; set; }
        public class DescribeBackupTasksResponseBodyItems : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<DescribeBackupTasksResponseBodyItemsBackupJob> BackupJob { get; set; }
            public class DescribeBackupTasksResponseBodyItemsBackupJob : TeaModel {
                [NameInMap("BackupJobId")]
                [Validation(Required=false)]
                public string BackupJobId { get; set; }

                [NameInMap("BackupProgressStatus")]
                [Validation(Required=false)]
                public string BackupProgressStatus { get; set; }

                [NameInMap("JobMode")]
                [Validation(Required=false)]
                public string JobMode { get; set; }

                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA8C1EF1-E3D4-44D7-B809-823187******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
