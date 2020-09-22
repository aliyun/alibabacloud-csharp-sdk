// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20180418.Models
{
    public class DescribeImagesQuery : TeaModel {
        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        [NameInMap("DockerVersion")]
        [Validation(Required=false)]
        public string DockerVersion { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
