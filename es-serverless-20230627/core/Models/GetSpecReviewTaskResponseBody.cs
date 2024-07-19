// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetSpecReviewTaskResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSpecReviewTaskResponseBodyResult Result { get; set; }
        public class GetSpecReviewTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("applyLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> ApplyLimiter { get; set; }

            [NameInMap("applyQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> ApplyQuota { get; set; }

            [NameInMap("applyReason")]
            [Validation(Required=false)]
            public string ApplyReason { get; set; }

            [NameInMap("effectiveLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectiveLimiter { get; set; }

            [NameInMap("effectiveQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectiveQuota { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("oldLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> OldLimiter { get; set; }

            [NameInMap("oldQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> OldQuota { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
