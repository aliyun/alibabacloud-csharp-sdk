// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightExceedApplyQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightExceedApplyQueryResponseBodyModule Module { get; set; }
        public class FlightExceedApplyQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("apply_intention_info_do")]
            [Validation(Required=false)]
            public FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo ApplyIntentionInfoDo { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("btrip_cause")]
            [Validation(Required=false)]
            public string BtripCause { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("exceed_reason")]
            [Validation(Required=false)]
            public string ExceedReason { get; set; }

            [NameInMap("exceed_type")]
            [Validation(Required=false)]
            public int? ExceedType { get; set; }

            [NameInMap("origin_standard")]
            [Validation(Required=false)]
            public string OriginStandard { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("submit_time")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

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
