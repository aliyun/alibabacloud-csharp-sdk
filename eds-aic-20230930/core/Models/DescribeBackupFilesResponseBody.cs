// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBackupFilesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupFilesResponseBodyData> Data { get; set; }
        public class DescribeBackupFilesResponseBodyData : TeaModel {
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            [NameInMap("BackupFileId")]
            [Validation(Required=false)]
            public string BackupFileId { get; set; }

            [NameInMap("BackupFileName")]
            [Validation(Required=false)]
            public string BackupFileName { get; set; }

            [NameInMap("BackupFilePath")]
            [Validation(Required=false)]
            public string BackupFilePath { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            [NameInMap("SourceFilePathList")]
            [Validation(Required=false)]
            public List<string> SourceFilePathList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UploadEndpoint")]
            [Validation(Required=false)]
            public string UploadEndpoint { get; set; }

            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
