// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckCreateDdrDBInstanceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        [NameInMap("BackupSetType")]
        [Validation(Required=false)]
        public string BackupSetType { get; set; }

        [NameInMap("BackupSetRegion")]
        [Validation(Required=false)]
        public string BackupSetRegion { get; set; }

        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        [NameInMap("UserBakSetURL")]
        [Validation(Required=false)]
        public string UserBakSetURL { get; set; }

        [NameInMap("BakSetName")]
        [Validation(Required=false)]
        public string BakSetName { get; set; }

        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        [NameInMap("BinlogName")]
        [Validation(Required=false)]
        public string BinlogName { get; set; }

        [NameInMap("BinlogPosition")]
        [Validation(Required=false)]
        public string BinlogPosition { get; set; }

        [NameInMap("BinlogRole")]
        [Validation(Required=false)]
        public string BinlogRole { get; set; }

    }

}
