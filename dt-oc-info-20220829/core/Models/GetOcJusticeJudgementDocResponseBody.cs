// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeJudgementDocResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeJudgementDocResponseBodyData> Data { get; set; }
        public class GetOcJusticeJudgementDocResponseBodyData : TeaModel {
            [NameInMap("CaseFlow")]
            [Validation(Required=false)]
            public string CaseFlow { get; set; }

            [NameInMap("CaseNum")]
            [Validation(Required=false)]
            public string CaseNum { get; set; }

            [NameInMap("CaseType")]
            [Validation(Required=false)]
            public string CaseType { get; set; }

            [NameInMap("CauseAction")]
            [Validation(Required=false)]
            public string CauseAction { get; set; }

            [NameInMap("Court")]
            [Validation(Required=false)]
            public string Court { get; set; }

            [NameInMap("Defendant")]
            [Validation(Required=false)]
            public string Defendant { get; set; }

            [NameInMap("JudgeDate")]
            [Validation(Required=false)]
            public string JudgeDate { get; set; }

            [NameInMap("JudgeResult")]
            [Validation(Required=false)]
            public string JudgeResult { get; set; }

            [NameInMap("JudgeType")]
            [Validation(Required=false)]
            public string JudgeType { get; set; }

            [NameInMap("Party")]
            [Validation(Required=false)]
            public string Party { get; set; }

            [NameInMap("Plaintiff")]
            [Validation(Required=false)]
            public string Plaintiff { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("SubAmount")]
            [Validation(Required=false)]
            public string SubAmount { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

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
