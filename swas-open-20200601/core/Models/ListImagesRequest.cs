// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListImagesRequest : TeaModel {
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
