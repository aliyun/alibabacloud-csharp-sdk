// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllMarketsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAllMarketsResponseDataList DataList { get; set; }
        public class GetAllMarketsResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAllMarketsResponseDataListUsageData> UsageData { get; set; }
            public class GetAllMarketsResponseDataListUsageData : TeaModel {
                public int? Code { get; set; }
                public string MarketCode { get; set; }
                public string MarketName { get; set; }
            }
        };

    }

}
