// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ModifyReplicationJobAttributeRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

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

        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public string ValidTime { get; set; }

        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class ModifyReplicationJobAttributeRequestSystemDiskPart : TeaModel {
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

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestDataDisk> DataDisk { get; set; }
        public class ModifyReplicationJobAttributeRequestDataDisk : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<ModifyReplicationJobAttributeRequestDataDiskPart> Part { get; set; }
            public class ModifyReplicationJobAttributeRequestDataDiskPart : TeaModel {
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

    }

}
