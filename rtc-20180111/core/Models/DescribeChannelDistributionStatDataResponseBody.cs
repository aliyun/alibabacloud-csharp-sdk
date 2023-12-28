// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelDistributionStatDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeChannelDistributionStatDataResponseBodyStatList> StatList { get; set; }
        public class DescribeChannelDistributionStatDataResponseBodyStatList : TeaModel {
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            [NameInMap("CallUserRatio")]
            [Validation(Required=false)]
            public string CallUserRatio { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
