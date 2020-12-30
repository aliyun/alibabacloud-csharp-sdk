// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeRequestStatisticCountByEsnBizGroup30MResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeRequestStatisticCountByEsnBizGroup30MResponseBodyStatistic> Statistic { get; set; }
        public class DescribeRequestStatisticCountByEsnBizGroup30MResponseBodyStatistic : TeaModel {
            [NameInMap("DetectIp")]
            [Validation(Required=false)]
            public string DetectIp { get; set; }

            [NameInMap("EsnGroupId")]
            [Validation(Required=false)]
            public string EsnGroupId { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
