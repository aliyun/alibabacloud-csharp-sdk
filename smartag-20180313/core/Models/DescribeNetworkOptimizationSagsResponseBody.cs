// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeNetworkOptimizationSagsResponseBody : TeaModel {
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

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public DescribeNetworkOptimizationSagsResponseBodySmartAccessGateways SmartAccessGateways { get; set; }
        public class DescribeNetworkOptimizationSagsResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("SmartAccessGateway")]
            [Validation(Required=false)]
            public List<DescribeNetworkOptimizationSagsResponseBodySmartAccessGatewaysSmartAccessGateway> SmartAccessGateway { get; set; }
            public class DescribeNetworkOptimizationSagsResponseBodySmartAccessGatewaysSmartAccessGateway : TeaModel {
                public long? EndTime { get; set; }
                public string State { get; set; }
                public long? CreateTime { get; set; }
                public string MaxBandwidth { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
