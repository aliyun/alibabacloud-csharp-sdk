// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceRequest : TeaModel {
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
