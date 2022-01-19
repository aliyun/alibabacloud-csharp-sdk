// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
