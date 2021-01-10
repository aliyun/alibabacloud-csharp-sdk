// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetTaskFileResultListResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public int? DataSize { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskFileResultListResponseBodyData Data { get; set; }
        public class GetTaskFileResultListResponseBodyData : TeaModel {
            [NameInMap("TaskResultReviewInfo")]
            [Validation(Required=false)]
            public List<GetTaskFileResultListResponseBodyDataTaskResultReviewInfo> TaskResultReviewInfo { get; set; }
            public class GetTaskFileResultListResponseBodyDataTaskResultReviewInfo : TeaModel {
                public int? Status { get; set; }
                public int? HitNumber { get; set; }
                public int? DataType { get; set; }
                public string NextVid { get; set; }
                public bool? HitRule { get; set; }
                public string PreVid { get; set; }
                public bool? IsHitRule { get; set; }
                public int? RealViolationNumber { get; set; }
                public float? ReviewAccuracyRate { get; set; }
                public string FileName { get; set; }
                public int? TotalScore { get; set; }
                public int? CheckNumber { get; set; }
                public string FileMergeName { get; set; }
                public string BucketName { get; set; }
                public bool? HandTaskFile { get; set; }
                public GetTaskFileResultListResponseBodyDataTaskResultReviewInfoHitRuleSet HitRuleSet { get; set; }
                public class GetTaskFileResultListResponseBodyDataTaskResultReviewInfoHitRuleSet : TeaModel {
                    [NameInMap("HitRuleSet")]
                    [Validation(Required=false)]
                    public List<string> HitRuleSet { get; set; }

                }
                public string TaskId { get; set; }
                public string Vid { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
