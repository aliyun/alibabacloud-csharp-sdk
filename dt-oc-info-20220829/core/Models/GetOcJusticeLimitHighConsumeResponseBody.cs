// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeLimitHighConsumeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeLimitHighConsumeResponseBodyData> Data { get; set; }
        public class GetOcJusticeLimitHighConsumeResponseBodyData : TeaModel {
            [NameInMap("CaseNum")]
            [Validation(Required=false)]
            public string CaseNum { get; set; }

            [NameInMap("CauseAction")]
            [Validation(Required=false)]
            public string CauseAction { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("Court")]
            [Validation(Required=false)]
            public string Court { get; set; }

            [NameInMap("ExecutionApplicant")]
            [Validation(Required=false)]
            public string ExecutionApplicant { get; set; }

            [NameInMap("FilingDate")]
            [Validation(Required=false)]
            public string FilingDate { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

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
