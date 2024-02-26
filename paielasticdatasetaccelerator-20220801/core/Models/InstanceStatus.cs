// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class InstanceStatus : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("SlotNum")]
        [Validation(Required=false)]
        public int? SlotNum { get; set; }

        [NameInMap("UsedCapacity")]
        [Validation(Required=false)]
        public string UsedCapacity { get; set; }

    }

}
