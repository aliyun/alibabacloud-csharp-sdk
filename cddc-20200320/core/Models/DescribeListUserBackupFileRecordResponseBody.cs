// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeListUserBackupFileRecordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeListUserBackupFileRecordResponseBodyRecords> Records { get; set; }
        public class DescribeListUserBackupFileRecordResponseBodyRecords : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            [NameInMap("OssFileSize")]
            [Validation(Required=false)]
            public long? OssFileSize { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("BinlogInfo")]
            [Validation(Required=false)]
            public string BinlogInfo { get; set; }

            [NameInMap("CustinsId")]
            [Validation(Required=false)]
            public string CustinsId { get; set; }

            [NameInMap("OssFileMetaData")]
            [Validation(Required=false)]
            public string OssFileMetaData { get; set; }

            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
