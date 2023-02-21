// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcInvestmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcInvestmentResponseBodyData> Data { get; set; }
        public class GetOcIcInvestmentResponseBodyData : TeaModel {
            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("InvestCreditCode")]
            [Validation(Required=false)]
            public string InvestCreditCode { get; set; }

            [NameInMap("InvestEsDate")]
            [Validation(Required=false)]
            public string InvestEsDate { get; set; }

            [NameInMap("InvestLegalName")]
            [Validation(Required=false)]
            public string InvestLegalName { get; set; }

            [NameInMap("InvestLicenseNo")]
            [Validation(Required=false)]
            public string InvestLicenseNo { get; set; }

            [NameInMap("InvestName")]
            [Validation(Required=false)]
            public string InvestName { get; set; }

            [NameInMap("InvestRegCap")]
            [Validation(Required=false)]
            public string InvestRegCap { get; set; }

            [NameInMap("InvestStatus")]
            [Validation(Required=false)]
            public string InvestStatus { get; set; }

            [NameInMap("ShouldCap")]
            [Validation(Required=false)]
            public string ShouldCap { get; set; }

            [NameInMap("StockPercentage")]
            [Validation(Required=false)]
            public string StockPercentage { get; set; }

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
