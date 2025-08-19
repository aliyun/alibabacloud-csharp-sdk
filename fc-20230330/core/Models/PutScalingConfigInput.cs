// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutScalingConfigInput : TeaModel {
        [NameInMap("residentConfig")]
        [Validation(Required=false)]
        public ResidentConfig ResidentConfig { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
