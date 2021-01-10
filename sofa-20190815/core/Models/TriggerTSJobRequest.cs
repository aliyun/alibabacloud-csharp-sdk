// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class TriggerTSJobRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("TargetServer")]
        [Validation(Required=false)]
        public string TargetServer { get; set; }

        [NameInMap("ZoneMode")]
        [Validation(Required=false)]
        public string ZoneMode { get; set; }

    }

}
