// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayFirstFrameDurationMetricDataRequest : TeaModel {
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public string BeginTs { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
