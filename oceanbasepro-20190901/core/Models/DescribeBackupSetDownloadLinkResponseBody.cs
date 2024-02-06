// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeBackupSetDownloadLinkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadLinkResponseBodyData Data { get; set; }
        public class DescribeBackupSetDownloadLinkResponseBodyData : TeaModel {
            [NameInMap("BackupRestorableTime")]
            [Validation(Required=false)]
            public string BackupRestorableTime { get; set; }

            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            [NameInMap("DownloadTaskCreateTime")]
            [Validation(Required=false)]
            public string DownloadTaskCreateTime { get; set; }

            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public long? DownloadTaskId { get; set; }

            [NameInMap("DownloadTaskStatus")]
            [Validation(Required=false)]
            public string DownloadTaskStatus { get; set; }

            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            [NameInMap("UrlAliveTime")]
            [Validation(Required=false)]
            public long? UrlAliveTime { get; set; }

            [NameInMap("UrlExpiredTime")]
            [Validation(Required=false)]
            public string UrlExpiredTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
