// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeFieldStatisticsResponseBodyGroupedFields : TeaModel {
            [NameInMap("OfflineInstanceCount")]
            [Validation(Required=false)]
            public int? OfflineInstanceCount { get; set; }
            [NameInMap("RegionCount")]
            [Validation(Required=false)]
            public int? RegionCount { get; set; }
            [NameInMap("NewInstanceCount")]
            [Validation(Required=false)]
            public int? NewInstanceCount { get; set; }
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }
            [NameInMap("ExposedInstanceCount")]
            [Validation(Required=false)]
            public int? ExposedInstanceCount { get; set; }
            [NameInMap("GeneralAssetCount")]
            [Validation(Required=false)]
            public int? GeneralAssetCount { get; set; }
            [NameInMap("UnprotectedInstanceCount")]
            [Validation(Required=false)]
            public int? UnprotectedInstanceCount { get; set; }
            [NameInMap("ImportantAssetCount")]
            [Validation(Required=false)]
            public int? ImportantAssetCount { get; set; }
            [NameInMap("TestAssetCount")]
            [Validation(Required=false)]
            public int? TestAssetCount { get; set; }
            [NameInMap("VpcCount")]
            [Validation(Required=false)]
            public int? VpcCount { get; set; }
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }
            [NameInMap("NotRunningStatusCount")]
            [Validation(Required=false)]
            public int? NotRunningStatusCount { get; set; }
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }
        };

    }

}
