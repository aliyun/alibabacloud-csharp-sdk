// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelAreaDistributionStatDataResponseBody : TeaModel {
        [NameInMap("AreaStatList")]
        [Validation(Required=false)]
        public List<DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList> AreaStatList { get; set; }
        public class DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList : TeaModel {
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            [NameInMap("HighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string HighQualityTransmissionRate { get; set; }

            [NameInMap("PubUserCount")]
            [Validation(Required=false)]
            public int? PubUserCount { get; set; }

            [NameInMap("SubUserCount")]
            [Validation(Required=false)]
            public int? SubUserCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
