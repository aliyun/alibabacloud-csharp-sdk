// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShowDataOption")]
        [Validation(Required=false)]
        public string ShowDataOption { get; set; }

        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
