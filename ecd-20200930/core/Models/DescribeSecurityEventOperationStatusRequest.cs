// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSecurityEventOperationStatusRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public List<string> SecurityEventId { get; set; }

    }

}
