// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeMetricDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public List<DescribeMetricDetailResponseBodyDatapoints> Datapoints { get; set; }
        public class DescribeMetricDetailResponseBodyDatapoints : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
