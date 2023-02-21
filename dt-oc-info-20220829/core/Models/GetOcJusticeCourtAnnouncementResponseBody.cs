// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeCourtAnnouncementResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeCourtAnnouncementResponseBodyData> Data { get; set; }
        public class GetOcJusticeCourtAnnouncementResponseBodyData : TeaModel {
            [NameInMap("CaseNum")]
            [Validation(Required=false)]
            public string CaseNum { get; set; }

            [NameInMap("CauseAction")]
            [Validation(Required=false)]
            public string CauseAction { get; set; }

            [NameInMap("Court")]
            [Validation(Required=false)]
            public string Court { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("HearingDate")]
            [Validation(Required=false)]
            public string HearingDate { get; set; }

            [NameInMap("Judge")]
            [Validation(Required=false)]
            public string Judge { get; set; }

            [NameInMap("Party")]
            [Validation(Required=false)]
            public string Party { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Tribunal")]
            [Validation(Required=false)]
            public string Tribunal { get; set; }

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
