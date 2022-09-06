// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CommonApplyQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CommonApplyQueryResponseBodyModule Module { get; set; }
        public class CommonApplyQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("biz_category")]
            [Validation(Required=false)]
            public int? BizCategory { get; set; }

            [NameInMap("cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("extend_value")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
