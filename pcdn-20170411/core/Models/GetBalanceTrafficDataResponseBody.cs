// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetBalanceTrafficDataResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetBalanceTrafficDataResponseBodyDataList DataList { get; set; }
        public class GetBalanceTrafficDataResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetBalanceTrafficDataResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetBalanceTrafficDataResponseBodyDataListUsageData : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public GetBalanceTrafficDataResponseBodyLabels Labels { get; set; }
        public class GetBalanceTrafficDataResponseBodyLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
