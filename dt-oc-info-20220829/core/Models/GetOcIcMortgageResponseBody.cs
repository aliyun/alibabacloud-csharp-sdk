// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcMortgageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcMortgageResponseBodyData> Data { get; set; }
        public class GetOcIcMortgageResponseBodyData : TeaModel {
            [NameInMap("DebitAmount")]
            [Validation(Required=false)]
            public string DebitAmount { get; set; }

            [NameInMap("DebitPeriod")]
            [Validation(Required=false)]
            public string DebitPeriod { get; set; }

            [NameInMap("DebitScope")]
            [Validation(Required=false)]
            public string DebitScope { get; set; }

            [NameInMap("DebitType")]
            [Validation(Required=false)]
            public string DebitType { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("Guarantees")]
            [Validation(Required=false)]
            public string Guarantees { get; set; }

            [NameInMap("IdentifyNo")]
            [Validation(Required=false)]
            public string IdentifyNo { get; set; }

            [NameInMap("IdentifyType")]
            [Validation(Required=false)]
            public string IdentifyType { get; set; }

            [NameInMap("MortgageesName")]
            [Validation(Required=false)]
            public string MortgageesName { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// ocid
            /// </summary>
            [NameInMap("OnecompId")]
            [Validation(Required=false)]
            public string OnecompId { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public string RegDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
