// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetClientsRatioResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetClientsRatioResponseBodyDataList DataList { get; set; }
        public class GetClientsRatioResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetClientsRatioResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetClientsRatioResponseBodyDataListUsageData : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
                public string Rate { get; set; }
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
