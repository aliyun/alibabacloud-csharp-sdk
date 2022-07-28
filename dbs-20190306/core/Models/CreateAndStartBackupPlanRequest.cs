// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateAndStartBackupPlanRequest : TeaModel {
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        [NameInMap("BackupRateLimit")]
        [Validation(Required=false)]
        public long? BackupRateLimit { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        [NameInMap("BackupStorageType")]
        [Validation(Required=false)]
        public string BackupStorageType { get; set; }

        [NameInMap("BackupStrategyType")]
        [Validation(Required=false)]
        public string BackupStrategyType { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        [NameInMap("DatabaseRegion")]
        [Validation(Required=false)]
        public string DatabaseRegion { get; set; }

        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        [NameInMap("DuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public int? DuplicationInfrequentAccessPeriod { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public bool? EnableBackupLog { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OSSBucketName")]
        [Validation(Required=false)]
        public string OSSBucketName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
