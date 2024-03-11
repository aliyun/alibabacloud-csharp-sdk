// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeUsageDistributionStatDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageDistributionStatDataResponseBodyUsageStatList> UsageStatList { get; set; }
        public class DescribeUsageDistributionStatDataResponseBodyUsageStatList : TeaModel {
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public long? AudioCallDuration { get; set; }

            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public long? TotalCallDuration { get; set; }

            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public long? VideoCallDuration { get; set; }

        }

    }

}
