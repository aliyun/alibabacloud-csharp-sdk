// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcNegativeCustomsPunishmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcNegativeCustomsPunishmentResponseBodyData> Data { get; set; }
        public class GetOcNegativeCustomsPunishmentResponseBodyData : TeaModel {
            [NameInMap("Basis")]
            [Validation(Required=false)]
            public string Basis { get; set; }

            [NameInMap("CaseNo")]
            [Validation(Required=false)]
            public string CaseNo { get; set; }

            [NameInMap("Customs")]
            [Validation(Required=false)]
            public string Customs { get; set; }

            [NameInMap("CustomsNo")]
            [Validation(Required=false)]
            public string CustomsNo { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("PunishDate")]
            [Validation(Required=false)]
            public string PunishDate { get; set; }

            [NameInMap("PunishType")]
            [Validation(Required=false)]
            public string PunishType { get; set; }

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
