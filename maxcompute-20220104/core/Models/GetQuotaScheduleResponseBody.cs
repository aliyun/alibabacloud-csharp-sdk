// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaScheduleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetQuotaScheduleResponseBodyData> Data { get; set; }
        public class GetQuotaScheduleResponseBodyData : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetQuotaScheduleResponseBodyDataCondition Condition { get; set; }
            public class GetQuotaScheduleResponseBodyDataCondition : TeaModel {
                [NameInMap("after")]
                [Validation(Required=false)]
                public string After { get; set; }

                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

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
