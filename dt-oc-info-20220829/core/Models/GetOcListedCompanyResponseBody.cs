// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcListedCompanyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcListedCompanyResponseBodyData> Data { get; set; }
        public class GetOcListedCompanyResponseBodyData : TeaModel {
            [NameInMap("CirculationMarketValue")]
            [Validation(Required=false)]
            public string CirculationMarketValue { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("EntNameEng")]
            [Validation(Required=false)]
            public string EntNameEng { get; set; }

            [NameInMap("ListDate")]
            [Validation(Required=false)]
            public string ListDate { get; set; }

            [NameInMap("SecuritiesCode")]
            [Validation(Required=false)]
            public string SecuritiesCode { get; set; }

            [NameInMap("SecuritiesMarket")]
            [Validation(Required=false)]
            public string SecuritiesMarket { get; set; }

            [NameInMap("SecuritiesName")]
            [Validation(Required=false)]
            public string SecuritiesName { get; set; }

            [NameInMap("TotalFlowShares")]
            [Validation(Required=false)]
            public string TotalFlowShares { get; set; }

            [NameInMap("TotalShares")]
            [Validation(Required=false)]
            public string TotalShares { get; set; }

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
