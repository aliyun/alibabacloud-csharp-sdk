// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeDishonestyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeDishonestyResponseBodyData> Data { get; set; }
        public class GetOcJusticeDishonestyResponseBodyData : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("CaseNum")]
            [Validation(Required=false)]
            public string CaseNum { get; set; }

            [NameInMap("Court")]
            [Validation(Required=false)]
            public string Court { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("ExecuteDepartment")]
            [Validation(Required=false)]
            public string ExecuteDepartment { get; set; }

            [NameInMap("ExecutionDesc")]
            [Validation(Required=false)]
            public string ExecutionDesc { get; set; }

            [NameInMap("ExecutionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            [NameInMap("FilingDate")]
            [Validation(Required=false)]
            public string FilingDate { get; set; }

            [NameInMap("FinalDuty")]
            [Validation(Required=false)]
            public string FinalDuty { get; set; }

            [NameInMap("FromCaseNum")]
            [Validation(Required=false)]
            public string FromCaseNum { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

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
