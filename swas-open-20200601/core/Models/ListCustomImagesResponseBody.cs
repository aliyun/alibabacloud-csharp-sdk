// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        [NameInMap("CustomImages")]
        [Validation(Required=false)]
        public List<ListCustomImagesResponseBodyCustomImages> CustomImages { get; set; }
        public class ListCustomImagesResponseBodyCustomImages : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DataSnapshotId")]
            [Validation(Required=false)]
            public string DataSnapshotId { get; set; }

            [NameInMap("DataSnapshotName")]
            [Validation(Required=false)]
            public string DataSnapshotName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InShare")]
            [Validation(Required=false)]
            public bool? InShare { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SystemSnapshotId")]
            [Validation(Required=false)]
            public string SystemSnapshotId { get; set; }

            [NameInMap("SystemSnapshotName")]
            [Validation(Required=false)]
            public string SystemSnapshotName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
