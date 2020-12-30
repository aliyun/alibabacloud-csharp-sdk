// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeNetworkOptimizationsResponseBody : TeaModel {
        [NameInMap("NetworkOptimizations")]
        [Validation(Required=false)]
        public DescribeNetworkOptimizationsResponseBodyNetworkOptimizations NetworkOptimizations { get; set; }
        public class DescribeNetworkOptimizationsResponseBodyNetworkOptimizations : TeaModel {
            [NameInMap("NetworkOptimization")]
            [Validation(Required=false)]
            public List<DescribeNetworkOptimizationsResponseBodyNetworkOptimizationsNetworkOptimization> NetworkOptimization { get; set; }
            public class DescribeNetworkOptimizationsResponseBodyNetworkOptimizationsNetworkOptimization : TeaModel {
                public int? SagCount { get; set; }
                public string State { get; set; }
                public long? CreateTime { get; set; }
                public string CcnId { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
