// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRequest : TeaModel {
        [NameInMap("ImageInstanceId")]
        [Validation(Required=false)]
        public string ImageInstanceId { get; set; }

        [NameInMap("ImageRegionId")]
        [Validation(Required=false)]
        public string ImageRegionId { get; set; }

        [NameInMap("ImageRepoId")]
        [Validation(Required=false)]
        public string ImageRepoId { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

    }

}
