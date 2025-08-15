// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetTraceRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
