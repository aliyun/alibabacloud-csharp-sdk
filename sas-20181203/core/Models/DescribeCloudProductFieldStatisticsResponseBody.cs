// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudProductFieldStatisticsResponseBody : TeaModel {
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeCloudProductFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeCloudProductFieldStatisticsResponseBodyGroupedFields : TeaModel {
            [NameInMap("CategoryCount")]
            [Validation(Required=false)]
            public string CategoryCount { get; set; }
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
