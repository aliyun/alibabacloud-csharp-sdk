// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CopyImageRequest : TeaModel {
        [NameInMap("DestinationDescription")]
        [Validation(Required=false)]
        public string DestinationDescription { get; set; }

        [NameInMap("DestinationImageName")]
        [Validation(Required=false)]
        public string DestinationImageName { get; set; }

        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
