// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UpgradeAICInstanceImageShrinkRequest : TeaModel {
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
