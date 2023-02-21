// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcOperationRecruitmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcOperationRecruitmentResponseBodyData> Data { get; set; }
        public class GetOcOperationRecruitmentResponseBodyData : TeaModel {
            [NameInMap("BenefitList")]
            [Validation(Required=false)]
            public string BenefitList { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Education")]
            [Validation(Required=false)]
            public string Education { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("Experience")]
            [Validation(Required=false)]
            public string Experience { get; set; }

            [NameInMap("PageUrl")]
            [Validation(Required=false)]
            public string PageUrl { get; set; }

            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

            [NameInMap("RecruitingAddress")]
            [Validation(Required=false)]
            public string RecruitingAddress { get; set; }

            [NameInMap("RecruitingName")]
            [Validation(Required=false)]
            public string RecruitingName { get; set; }

            [NameInMap("Salary")]
            [Validation(Required=false)]
            public string Salary { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

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
