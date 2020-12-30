// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetBandwidthDataResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetBandwidthDataResponseBodyDataList DataList { get; set; }
        public class GetBandwidthDataResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetBandwidthDataResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetBandwidthDataResponseBodyDataListUsageData : TeaModel {
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
        public GetBandwidthDataResponseBodyLabels Labels { get; set; }
        public class GetBandwidthDataResponseBodyLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
