/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateReplicationJobRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public string ValidTime { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ReplicationParameters")]
        [Validation(Required=false)]
        public string ReplicationParameters { get; set; }

        [NameInMap("NetMode")]
        [Validation(Required=false)]
        public int? NetMode { get; set; }

        [NameInMap("RunOnce")]
        [Validation(Required=false)]
        public bool? RunOnce { get; set; }

        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        [NameInMap("MaxNumberOfImageToKeep")]
        [Validation(Required=false)]
        public int? MaxNumberOfImageToKeep { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        [NameInMap("InstanceRamRole")]
        [Validation(Required=false)]
        public string InstanceRamRole { get; set; }

        [NameInMap("ContainerNamespace")]
        [Validation(Required=false)]
        public string ContainerNamespace { get; set; }

        [NameInMap("ContainerRepository")]
        [Validation(Required=false)]
        public string ContainerRepository { get; set; }

        [NameInMap("ContainerTag")]
        [Validation(Required=false)]
        public string ContainerTag { get; set; }

        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestDataDisk> DataDisk { get; set; }
        public class CreateReplicationJobRequestDataDisk : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<CreateReplicationJobRequestDataDiskPart> Part { get; set; }
            public class CreateReplicationJobRequestDataDiskPart : TeaModel {
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

                [NameInMap("Block")]
                [Validation(Required=false)]
                public bool? Block { get; set; }

                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestTag> Tag { get; set; }
        public class CreateReplicationJobRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class CreateReplicationJobRequestSystemDiskPart : TeaModel {
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            [NameInMap("Block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

        }

    }

}
