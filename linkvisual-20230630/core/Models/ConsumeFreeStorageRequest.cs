// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class ConsumeFreeStorageRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EnableDefaultPlan")]
        [Validation(Required=false)]
        public bool? EnableDefaultPlan { get; set; }

        [NameInMap("EventRecordDuration")]
        [Validation(Required=false)]
        public int? EventRecordDuration { get; set; }

        [NameInMap("EventRecordProlong")]
        [Validation(Required=false)]
        public bool? EventRecordProlong { get; set; }

        [NameInMap("ImmediateUse")]
        [Validation(Required=false)]
        public bool? ImmediateUse { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("PreRecordDuration")]
        [Validation(Required=false)]
        public int? PreRecordDuration { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Quota")]
        [Validation(Required=false)]
        public int? Quota { get; set; }

    }

}
