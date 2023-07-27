// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class BucketStat : TeaModel {
        [NameInMap("ArchiveObjectCount")]
        [Validation(Required=false)]
        public long? ArchiveObjectCount { get; set; }

        [NameInMap("ArchiveRealStorage")]
        [Validation(Required=false)]
        public long? ArchiveRealStorage { get; set; }

        [NameInMap("ArchiveStorage")]
        [Validation(Required=false)]
        public long? ArchiveStorage { get; set; }

        [NameInMap("ColdArchiveObjectCount")]
        [Validation(Required=false)]
        public long? ColdArchiveObjectCount { get; set; }

        [NameInMap("ColdArchiveRealStorage")]
        [Validation(Required=false)]
        public long? ColdArchiveRealStorage { get; set; }

        [NameInMap("ColdArchiveStorage")]
        [Validation(Required=false)]
        public long? ColdArchiveStorage { get; set; }

        [NameInMap("InfrequentAccessObjectCount")]
        [Validation(Required=false)]
        public long? InfrequentAccessObjectCount { get; set; }

        [NameInMap("InfrequentAccessRealStorage")]
        [Validation(Required=false)]
        public long? InfrequentAccessRealStorage { get; set; }

        [NameInMap("InfrequentAccessStorage")]
        [Validation(Required=false)]
        public long? InfrequentAccessStorage { get; set; }

        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        [NameInMap("LiveChannelCount")]
        [Validation(Required=false)]
        public long? LiveChannelCount { get; set; }

        [NameInMap("MultipartUploadCount")]
        [Validation(Required=false)]
        public long? MultipartUploadCount { get; set; }

        [NameInMap("ObjectCount")]
        [Validation(Required=false)]
        public long? ObjectCount { get; set; }

        [NameInMap("StandardObjectCount")]
        [Validation(Required=false)]
        public long? StandardObjectCount { get; set; }

        [NameInMap("StandardStorage")]
        [Validation(Required=false)]
        public long? StandardStorage { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public long? Storage { get; set; }

    }

}
