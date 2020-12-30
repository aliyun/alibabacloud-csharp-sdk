// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetCoverRateDataResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetCoverRateDataResponseBodyDataList DataList { get; set; }
        public class GetCoverRateDataResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetCoverRateDataResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetCoverRateDataResponseBodyDataListUsageData : TeaModel {
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
        public GetCoverRateDataResponseBodyLabels Labels { get; set; }
        public class GetCoverRateDataResponseBodyLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
