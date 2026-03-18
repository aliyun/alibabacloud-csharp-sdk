// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsByInstanceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeMetricsByInstanceResponseBodyData Data { get; set; }
        public class ListComputeMetricsByInstanceResponseBodyData : TeaModel {
            [NameInMap("instanceComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics> InstanceComputeMetrics { get; set; }
            public class ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                [NameInMap("specCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                [NameInMap("submitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
