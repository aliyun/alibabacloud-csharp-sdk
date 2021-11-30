// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplateByScratchRequest : TeaModel {
        [NameInMap("ProvisionRegionId")]
        [Validation(Required=false)]
        public string ProvisionRegionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
