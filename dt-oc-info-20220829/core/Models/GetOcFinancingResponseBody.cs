// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcFinancingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcFinancingResponseBodyData> Data { get; set; }
        public class GetOcFinancingResponseBodyData : TeaModel {
            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("FinAmount")]
            [Validation(Required=false)]
            public string FinAmount { get; set; }

            [NameInMap("FinDate")]
            [Validation(Required=false)]
            public string FinDate { get; set; }

            [NameInMap("FinTurn")]
            [Validation(Required=false)]
            public string FinTurn { get; set; }

            [NameInMap("Investors")]
            [Validation(Required=false)]
            public string Investors { get; set; }

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
