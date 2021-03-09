// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSnapshotRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=true)]
        public string DesktopId { get; set; }

        [NameInMap("SnapshotName")]
        [Validation(Required=true)]
        public string SnapshotName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SourceDiskType")]
        [Validation(Required=true)]
        public string SourceDiskType { get; set; }

    }

}
