// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetFileSystemResponseBody : TeaModel {
        [NameInMap("FileSystem")]
        [Validation(Required=false)]
        public GetFileSystemResponseBodyFileSystem FileSystem { get; set; }
        public class GetFileSystemResponseBodyFileSystem : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            [NameInMap("MeteringSpaceSize")]
            [Validation(Required=false)]
            public float? MeteringSpaceSize { get; set; }

            [NameInMap("MountPointCount")]
            [Validation(Required=false)]
            public long? MountPointCount { get; set; }

            [NameInMap("NumberOfDirectories")]
            [Validation(Required=false)]
            public long? NumberOfDirectories { get; set; }

            [NameInMap("NumberOfFiles")]
            [Validation(Required=false)]
            public long? NumberOfFiles { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("ProvisionedThroughputInMiBps")]
            [Validation(Required=false)]
            public long? ProvisionedThroughputInMiBps { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SpaceCapacity")]
            [Validation(Required=false)]
            public long? SpaceCapacity { get; set; }

            [NameInMap("StoragePackageId")]
            [Validation(Required=false)]
            public string StoragePackageId { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("ThroughputMode")]
            [Validation(Required=false)]
            public string ThroughputMode { get; set; }

            [NameInMap("UsedSpaceSize")]
            [Validation(Required=false)]
            public float? UsedSpaceSize { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
