// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImagesRequest : TeaModel {
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
