// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcSimpleCancelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcSimpleCancelResponseBodyData> Data { get; set; }
        public class GetOcIcSimpleCancelResponseBodyData : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("NoticePeriod")]
            [Validation(Required=false)]
            public string NoticePeriod { get; set; }

            [NameInMap("ScaContent")]
            [Validation(Required=false)]
            public string ScaContent { get; set; }

            [NameInMap("ScaDate")]
            [Validation(Required=false)]
            public string ScaDate { get; set; }

            [NameInMap("ScaProposer")]
            [Validation(Required=false)]
            public string ScaProposer { get; set; }

            [NameInMap("ScaResult")]
            [Validation(Required=false)]
            public string ScaResult { get; set; }

            [NameInMap("ScaResultDate")]
            [Validation(Required=false)]
            public string ScaResultDate { get; set; }

            [NameInMap("SocialCreditCode")]
            [Validation(Required=false)]
            public string SocialCreditCode { get; set; }

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
