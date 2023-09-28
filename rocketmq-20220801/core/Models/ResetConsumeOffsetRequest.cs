// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ResetConsumeOffsetRequest : TeaModel {
        [NameInMap("resetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        [NameInMap("resetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
