// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetComputeQuotaScheduleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetComputeQuotaScheduleResponseBodyData> Data { get; set; }
        public class GetComputeQuotaScheduleResponseBodyData : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetComputeQuotaScheduleResponseBodyDataCondition Condition { get; set; }
            public class GetComputeQuotaScheduleResponseBodyDataCondition : TeaModel {
                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("plan")]
            [Validation(Required=false)]
            public string Plan { get; set; }

            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
