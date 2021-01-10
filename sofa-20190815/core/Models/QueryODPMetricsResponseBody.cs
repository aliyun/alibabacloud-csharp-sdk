// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryODPMetricsResponseBodyData> Data { get; set; }
        public class QueryODPMetricsResponseBodyData : TeaModel {
            [NameInMap("MetricsType")]
            [Validation(Required=false)]
            public string MetricsType { get; set; }

            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            [NameInMap("MertricsValues")]
            [Validation(Required=false)]
            public List<QueryODPMetricsResponseBodyDataMertricsValues> MertricsValues { get; set; }
            public class QueryODPMetricsResponseBodyDataMertricsValues : TeaModel {
                [NameInMap("T")]
                [Validation(Required=false)]
                public long? T { get; set; }

                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

        }

    }

}
