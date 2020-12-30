// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllMarketsResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAllMarketsResponseBodyDataList DataList { get; set; }
        public class GetAllMarketsResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetAllMarketsResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetAllMarketsResponseBodyDataListUsageData : TeaModel {
                public int? Code { get; set; }
                public string MarketCode { get; set; }
                public string MarketName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
