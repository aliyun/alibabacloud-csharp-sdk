// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupSetDownloadTaskListResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadTaskListResponseBodyItems Items { get; set; }
        public class DescribeBackupSetDownloadTaskListResponseBodyItems : TeaModel {
            [NameInMap("BackupSetDownloadTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail> BackupSetDownloadTaskDetail { get; set; }
            public class DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail : TeaModel {
                public string BackupSetDownloadStatus { get; set; }
                public long? BackupSetDataSize { get; set; }
                public string BackupSetDownloadDir { get; set; }
                public string BackupSetDownloadTargetType { get; set; }
                public string ErrMessage { get; set; }
                public string BackupPlanId { get; set; }
                public long? BackupSetDownloadCreateTime { get; set; }
                public string BackupSetDbType { get; set; }
                public string BackupSetDownloadInternetUrl { get; set; }
                public string BackupSetId { get; set; }
                public long? BackupGatewayId { get; set; }
                public string BackupSetDownloadIntranetUrl { get; set; }
                public string BackupSetDownloadWay { get; set; }
                public long? BackupSetDownloadFinishTime { get; set; }
                public string BackupSetJobType { get; set; }
                public string BackupSetDownloadTaskId { get; set; }
                public string BackupSetDownloadTaskName { get; set; }
                public string BackupSetDataFormat { get; set; }
                public string BackupSetCode { get; set; }
            }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
