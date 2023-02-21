// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcCompetitorsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcCompetitorsResponseBodyData> Data { get; set; }
        public class GetOcCompetitorsResponseBodyData : TeaModel {
            [NameInMap("CompetitionBrandIntroduction")]
            [Validation(Required=false)]
            public string CompetitionBrandIntroduction { get; set; }

            [NameInMap("CompetitionEntAddress")]
            [Validation(Required=false)]
            public string CompetitionEntAddress { get; set; }

            [NameInMap("CompetitionEntEsDate")]
            [Validation(Required=false)]
            public string CompetitionEntEsDate { get; set; }

            [NameInMap("CompetitionEntFinTurn")]
            [Validation(Required=false)]
            public string CompetitionEntFinTurn { get; set; }

            [NameInMap("CompetitionEntName")]
            [Validation(Required=false)]
            public string CompetitionEntName { get; set; }

            [NameInMap("CompetitionIntroduction")]
            [Validation(Required=false)]
            public string CompetitionIntroduction { get; set; }

            [NameInMap("CompetitionLogoUrl")]
            [Validation(Required=false)]
            public string CompetitionLogoUrl { get; set; }

            [NameInMap("CompetitionProductName")]
            [Validation(Required=false)]
            public string CompetitionProductName { get; set; }

            [NameInMap("CompetitionTag")]
            [Validation(Required=false)]
            public string CompetitionTag { get; set; }

            [NameInMap("CompetitionWebsite")]
            [Validation(Required=false)]
            public string CompetitionWebsite { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

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
