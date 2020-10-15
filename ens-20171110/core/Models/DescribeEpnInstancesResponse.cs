// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("EPNInstances")]
        [Validation(Required=true)]
        public DescribeEpnInstancesResponseEPNInstances EPNInstances { get; set; }
        public class DescribeEpnInstancesResponseEPNInstances : TeaModel {
            [NameInMap("EPNInstance")]
            [Validation(Required=true)]
            public List<DescribeEpnInstancesResponseEPNInstancesEPNInstance> EPNInstance { get; set; }
            public class DescribeEpnInstancesResponseEPNInstancesEPNInstance : TeaModel {
                public string EPNInstanceId { get; set; }
                public string EPNInstanceName { get; set; }
                public string NetworkingModel { get; set; }
                public string ModifyTime { get; set; }
                public string EPNInstanceType { get; set; }
                public string Status { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public string CreationTime { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
            }
        };

    }

}
