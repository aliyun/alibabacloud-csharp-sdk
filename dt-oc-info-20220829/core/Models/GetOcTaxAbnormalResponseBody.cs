// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcTaxAbnormalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcTaxAbnormalResponseBodyData> Data { get; set; }
        public class GetOcTaxAbnormalResponseBodyData : TeaModel {
            [NameInMap("CardNum")]
            [Validation(Required=false)]
            public string CardNum { get; set; }

            [NameInMap("CardType")]
            [Validation(Required=false)]
            public string CardType { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("JudgeDate")]
            [Validation(Required=false)]
            public string JudgeDate { get; set; }

            [NameInMap("JudgeDepartment")]
            [Validation(Required=false)]
            public string JudgeDepartment { get; set; }

            [NameInMap("JudgeReason")]
            [Validation(Required=false)]
            public string JudgeReason { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("OverdueAmount")]
            [Validation(Required=false)]
            public string OverdueAmount { get; set; }

            [NameInMap("OverdueType")]
            [Validation(Required=false)]
            public string OverdueType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaxpayerNum")]
            [Validation(Required=false)]
            public string TaxpayerNum { get; set; }

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
