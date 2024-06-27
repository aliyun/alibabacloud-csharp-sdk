// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRecommendTaskPageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeRecommendTaskPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeRecommendTaskPageListResponseBodyResultObject : TeaModel {
            [NameInMap("expectVelocities")]
            [Validation(Required=false)]
            public List<string> ExpectVelocities { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("normalCount")]
            [Validation(Required=false)]
            public long? NormalCount { get; set; }

            [NameInMap("normalSize")]
            [Validation(Required=false)]
            public long? NormalSize { get; set; }

            [NameInMap("riskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("riskSize")]
            [Validation(Required=false)]
            public long? RiskSize { get; set; }

            [NameInMap("sampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            [NameInMap("sampleScene")]
            [Validation(Required=false)]
            public string SampleScene { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
