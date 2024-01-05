// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDataBackupSetResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataBackupSetResponseBodyData> Data { get; set; }
        public class DescribeDataBackupSetResponseBodyData : TeaModel {
            [NameInMap("BackupObjectType")]
            [Validation(Required=false)]
            public string BackupObjectType { get; set; }

            [NameInMap("BackupObjects")]
            [Validation(Required=false)]
            public List<DescribeDataBackupSetResponseBodyDataBackupObjects> BackupObjects { get; set; }
            public class DescribeDataBackupSetResponseBodyDataBackupObjects : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("DatabaseTablesList")]
                [Validation(Required=false)]
                public List<DescribeDataBackupSetResponseBodyDataBackupObjectsDatabaseTablesList> DatabaseTablesList { get; set; }
                public class DescribeDataBackupSetResponseBodyDataBackupObjectsDatabaseTablesList : TeaModel {
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            [NameInMap("BackupResults")]
            [Validation(Required=false)]
            public List<DescribeDataBackupSetResponseBodyDataBackupResults> BackupResults { get; set; }
            public class DescribeDataBackupSetResponseBodyDataBackupResults : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("TableBackupResults")]
                [Validation(Required=false)]
                public List<DescribeDataBackupSetResponseBodyDataBackupResultsTableBackupResults> TableBackupResults { get; set; }
                public class DescribeDataBackupSetResponseBodyDataBackupResultsTableBackupResults : TeaModel {
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public int? DataSize { get; set; }

            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public int? DataVersion { get; set; }

            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public long? DownloadTaskId { get; set; }

            [NameInMap("DownloadTaskStatus")]
            [Validation(Required=false)]
            public string DownloadTaskStatus { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("SetId")]
            [Validation(Required=false)]
            public int? SetId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Validity")]
            [Validation(Required=false)]
            public string Validity { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
