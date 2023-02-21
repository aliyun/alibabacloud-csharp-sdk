// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcEquityFrozenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcEquityFrozenResponseBodyData> Data { get; set; }
        public class GetOcIcEquityFrozenResponseBodyData : TeaModel {
            [NameInMap("FreezeAmount")]
            [Validation(Required=false)]
            public string FreezeAmount { get; set; }

            [NameInMap("FreezeCardNum")]
            [Validation(Required=false)]
            public string FreezeCardNum { get; set; }

            [NameInMap("FreezeCardType")]
            [Validation(Required=false)]
            public string FreezeCardType { get; set; }

            [NameInMap("FreezeCourt")]
            [Validation(Required=false)]
            public string FreezeCourt { get; set; }

            [NameInMap("FreezeEndDate")]
            [Validation(Required=false)]
            public string FreezeEndDate { get; set; }

            [NameInMap("FreezeExecItem")]
            [Validation(Required=false)]
            public string FreezeExecItem { get; set; }

            [NameInMap("FreezeExecPerson")]
            [Validation(Required=false)]
            public string FreezeExecPerson { get; set; }

            [NameInMap("FreezeNoticeNum")]
            [Validation(Required=false)]
            public string FreezeNoticeNum { get; set; }

            [NameInMap("FreezePublishDate")]
            [Validation(Required=false)]
            public string FreezePublishDate { get; set; }

            [NameInMap("FreezeStartDate")]
            [Validation(Required=false)]
            public string FreezeStartDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnfreezeAdjustNum")]
            [Validation(Required=false)]
            public string UnfreezeAdjustNum { get; set; }

            [NameInMap("UnfreezeCourt")]
            [Validation(Required=false)]
            public string UnfreezeCourt { get; set; }

            [NameInMap("UnfreezeDate")]
            [Validation(Required=false)]
            public string UnfreezeDate { get; set; }

            [NameInMap("UnfreezeReason")]
            [Validation(Required=false)]
            public string UnfreezeReason { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
