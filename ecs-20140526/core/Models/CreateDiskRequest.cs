// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
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

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        [NameInMap("DedicatedBlockStorageClusterId")]
        [Validation(Required=false)]
        public string DedicatedBlockStorageClusterId { get; set; }

        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

        }

    }

}
