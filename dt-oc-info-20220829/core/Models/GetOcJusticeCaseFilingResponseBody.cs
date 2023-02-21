// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeCaseFilingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeCaseFilingResponseBodyData> Data { get; set; }
        public class GetOcJusticeCaseFilingResponseBodyData : TeaModel {
            [NameInMap("Assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            [NameInMap("CaseNum")]
            [Validation(Required=false)]
            public string CaseNum { get; set; }

            [NameInMap("CaseStatus")]
            [Validation(Required=false)]
            public string CaseStatus { get; set; }

            [NameInMap("CauseAction")]
            [Validation(Required=false)]
            public string CauseAction { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("FilingDate")]
            [Validation(Required=false)]
            public string FilingDate { get; set; }

            [NameInMap("HearingDate")]
            [Validation(Required=false)]
            public string HearingDate { get; set; }

            [NameInMap("Judge")]
            [Validation(Required=false)]
            public string Judge { get; set; }

            [NameInMap("Party")]
            [Validation(Required=false)]
            public string Party { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

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
