// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeMetricDataResponseBodyDataList> DataList { get; set; }
        public class DescribeMetricDataResponseBodyDataList : TeaModel {
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public object Datapoints { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public object Labels { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
