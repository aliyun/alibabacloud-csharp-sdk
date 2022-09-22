// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ModifyOrderAutoRebootTimeResponseBody : TeaModel {
        [NameInMap("ModifyOrderAutoRebootTimeInfo")]
        [Validation(Required=false)]
        public ModifyOrderAutoRebootTimeResponseBodyModifyOrderAutoRebootTimeInfo ModifyOrderAutoRebootTimeInfo { get; set; }
        public class ModifyOrderAutoRebootTimeResponseBodyModifyOrderAutoRebootTimeInfo : TeaModel {
            [NameInMap("AutoRebootTime")]
            [Validation(Required=false)]
            public string AutoRebootTime { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
