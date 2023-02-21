// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcEquityPledgeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcEquityPledgeResponseBodyData> Data { get; set; }
        public class GetOcIcEquityPledgeResponseBodyData : TeaModel {
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("Pawnee")]
            [Validation(Required=false)]
            public string Pawnee { get; set; }

            [NameInMap("PawneeIdentifyNo")]
            [Validation(Required=false)]
            public string PawneeIdentifyNo { get; set; }

            [NameInMap("Pledgor")]
            [Validation(Required=false)]
            public string Pledgor { get; set; }

            [NameInMap("PledgorAmount")]
            [Validation(Required=false)]
            public string PledgorAmount { get; set; }

            [NameInMap("PledgorIdentifyNo")]
            [Validation(Required=false)]
            public string PledgorIdentifyNo { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public string RegDate { get; set; }

            [NameInMap("RelatedComp")]
            [Validation(Required=false)]
            public string RelatedComp { get; set; }

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
