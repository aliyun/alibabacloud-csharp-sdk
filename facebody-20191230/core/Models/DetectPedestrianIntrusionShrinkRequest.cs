// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianIntrusionShrinkRequest : TeaModel {
        [NameInMap("DetectRegion")]
        [Validation(Required=false)]
        public string DetectRegionShrink { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("RegionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

    }

}
