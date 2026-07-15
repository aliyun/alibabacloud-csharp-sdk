// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<EstimatedPriceQueryV2ResponseBodyModule> Module { get; set; }
        public class EstimatedPriceQueryV2ResponseBodyModule : TeaModel {
            [NameInMap("biz_type")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("price_map")]
            [Validation(Required=false)]
            public Dictionary<string, ModulePriceMapValue> PriceMap { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
