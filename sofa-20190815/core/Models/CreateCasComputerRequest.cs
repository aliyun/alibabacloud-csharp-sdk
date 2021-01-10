// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateCasComputerRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public string AppServiceId { get; set; }

        [NameInMap("CellId")]
        [Validation(Required=false)]
        public string CellId { get; set; }

        [NameInMap("CommonImageSequence")]
        [Validation(Required=false)]
        public string CommonImageSequence { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ImageSequence")]
        [Validation(Required=false)]
        public string ImageSequence { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("SecurityGroupSequence")]
        [Validation(Required=false)]
        public string SecurityGroupSequence { get; set; }

        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public string SpecId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public long? SystemDiskSize { get; set; }

        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<CreateCasComputerRequestDataDisks> DataDisks { get; set; }
        public class CreateCasComputerRequestDataDisks : TeaModel {
            [NameInMap("SnapshotSequence")]
            [Validation(Required=false)]
            public string SnapshotSequence { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

        }

    }

}
