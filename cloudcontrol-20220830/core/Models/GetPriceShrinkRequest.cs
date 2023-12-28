// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetPriceShrinkRequest : TeaModel {
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resourceAttributes")]
        [Validation(Required=false)]
        public string ResourceAttributesShrink { get; set; }

    }

}
