// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ModifyFileSystemRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("FileSystemName")]
        [Validation(Required=false)]
        public string FileSystemName { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("ProvisionedThroughputInMiBps")]
        [Validation(Required=false)]
        public long? ProvisionedThroughputInMiBps { get; set; }

        [NameInMap("SpaceCapacity")]
        [Validation(Required=false)]
        public long? SpaceCapacity { get; set; }

        [NameInMap("ThroughputMode")]
        [Validation(Required=false)]
        public string ThroughputMode { get; set; }

    }

}
