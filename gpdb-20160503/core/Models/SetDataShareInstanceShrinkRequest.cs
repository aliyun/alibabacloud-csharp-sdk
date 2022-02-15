// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class SetDataShareInstanceShrinkRequest : TeaModel {
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceListShrink { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
