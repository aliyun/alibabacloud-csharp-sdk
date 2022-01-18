// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SupportDriftDetection")]
        [Validation(Required=false)]
        public bool? SupportDriftDetection { get; set; }

        [NameInMap("SupportScratchDetection")]
        [Validation(Required=false)]
        public bool? SupportScratchDetection { get; set; }

    }

}
