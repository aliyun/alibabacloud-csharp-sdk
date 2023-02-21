// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcShareholderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcShareholderResponseBodyData> Data { get; set; }
        public class GetOcIcShareholderResponseBodyData : TeaModel {
            [NameInMap("ShouldCap")]
            [Validation(Required=false)]
            public string ShouldCap { get; set; }

            [NameInMap("ShouldCapTime")]
            [Validation(Required=false)]
            public string ShouldCapTime { get; set; }

            [NameInMap("StockName")]
            [Validation(Required=false)]
            public string StockName { get; set; }

            [NameInMap("StockPercent")]
            [Validation(Required=false)]
            public string StockPercent { get; set; }

            [NameInMap("StockType")]
            [Validation(Required=false)]
            public string StockType { get; set; }

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
