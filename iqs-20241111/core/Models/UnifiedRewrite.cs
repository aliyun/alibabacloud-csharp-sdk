// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedRewrite : TeaModel {
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
