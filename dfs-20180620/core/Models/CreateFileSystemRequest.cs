// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateFileSystemRequest : TeaModel {
        [NameInMap("DataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FileSystemName")]
        [Validation(Required=false)]
        public string FileSystemName { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("PartitionNumber")]
        [Validation(Required=false)]
        public int? PartitionNumber { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("ProvisionedThroughputInMiBps")]
        [Validation(Required=false)]
        public long? ProvisionedThroughputInMiBps { get; set; }

        [NameInMap("SpaceCapacity")]
        [Validation(Required=false)]
        public long? SpaceCapacity { get; set; }

        [NameInMap("StorageSetName")]
        [Validation(Required=false)]
        public string StorageSetName { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("ThroughputMode")]
        [Validation(Required=false)]
        public string ThroughputMode { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
