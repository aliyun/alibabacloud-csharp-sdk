// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcNegativeFoodDrugPunishmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcNegativeFoodDrugPunishmentResponseBodyData> Data { get; set; }
        public class GetOcNegativeFoodDrugPunishmentResponseBodyData : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("IllegalType")]
            [Validation(Required=false)]
            public string IllegalType { get; set; }

            [NameInMap("LawBasis")]
            [Validation(Required=false)]
            public string LawBasis { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("PunishDate")]
            [Validation(Required=false)]
            public string PunishDate { get; set; }

            [NameInMap("PunishNum")]
            [Validation(Required=false)]
            public string PunishNum { get; set; }

            [NameInMap("PunishResult")]
            [Validation(Required=false)]
            public string PunishResult { get; set; }

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
