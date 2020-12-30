// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListResponseBody : TeaModel {
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
        public DescribeBackupPlanListResponseBodyItems Items { get; set; }
        public class DescribeBackupPlanListResponseBodyItems : TeaModel {
            [NameInMap("BackupPlanDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupPlanListResponseBodyItemsBackupPlanDetail> BackupPlanDetail { get; set; }
            public class DescribeBackupPlanListResponseBodyItemsBackupPlanDetail : TeaModel {
                public string CrossRoleName { get; set; }
                public string SourceEndpointInstanceType { get; set; }
                public string BackupSetDownloadDir { get; set; }
                public string SourceEndpointIpPort { get; set; }
                public string CrossAliyunId { get; set; }
                public int? DuplicationArchivePeriod { get; set; }
                public string BackupPlanId { get; set; }
                public long? EndTimestampForRestore { get; set; }
                public string BackupPlanStatus { get; set; }
                public string BackupSetDownloadFullDataFormat { get; set; }
                public int? BackupRetentionPeriod { get; set; }
                public string OSSBucketRegion { get; set; }
                public string SourceEndpointOracleSID { get; set; }
                public string BackupStorageType { get; set; }
                public string BackupMethod { get; set; }
                public string SourceEndpointRegion { get; set; }
                public string SourceEndpointDatabaseName { get; set; }
                public string BackupPeriod { get; set; }
                public long? BackupSetDownloadGatewayId { get; set; }
                public string InstanceClass { get; set; }
                public long? BackupPlanCreateTime { get; set; }
                public string BackupStartTime { get; set; }
                public int? DuplicationInfrequentAccessPeriod { get; set; }
                public string BackupSetDownloadTargetType { get; set; }
                public string ErrMessage { get; set; }
                public string BackupObjects { get; set; }
                public long? BeginTimestampForRestore { get; set; }
                public string SourceEndpointInstanceID { get; set; }
                public bool? OpenBackupSetAutoDownload { get; set; }
                public string BackupPlanName { get; set; }
                public string OSSBucketName { get; set; }
                public long? BackupGatewayId { get; set; }
                public string SourceEndpointUserName { get; set; }
                public string BackupSetDownloadIncrementDataFormat { get; set; }
                public bool? EnableBackupLog { get; set; }
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
