// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeRequestStatisticCountByEsnBiz1DayProvinceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeRequestStatisticCountByEsnBiz1DayProvinceResponseBodyStatistic> Statistic { get; set; }
        public class DescribeRequestStatisticCountByEsnBiz1DayProvinceResponseBodyStatistic : TeaModel {
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public long? FailureCount { get; set; }

            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public long? ProvinceId { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
