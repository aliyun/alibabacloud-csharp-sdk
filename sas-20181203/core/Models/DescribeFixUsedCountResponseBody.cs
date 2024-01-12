// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFixUsedCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        [NameInMap("UsedCountCn")]
        [Validation(Required=false)]
        public int? UsedCountCn { get; set; }

        [NameInMap("UsedCountSg")]
        [Validation(Required=false)]
        public int? UsedCountSg { get; set; }

    }

}
