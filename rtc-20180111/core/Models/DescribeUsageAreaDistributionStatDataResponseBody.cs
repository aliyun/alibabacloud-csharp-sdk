// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageAreaDistributionStatDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageAreaStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList> UsageAreaStatList { get; set; }
        public class DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList : TeaModel {
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public int? AudioCallDuration { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public int? TotalCallDuration { get; set; }

            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public int? VideoCallDuration { get; set; }

        }

    }

}
