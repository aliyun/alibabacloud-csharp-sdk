// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstancesResponseBody : TeaModel {
        [NameInMap("EPNInstances")]
        [Validation(Required=false)]
        public DescribeEpnInstancesResponseBodyEPNInstances EPNInstances { get; set; }
        public class DescribeEpnInstancesResponseBodyEPNInstances : TeaModel {
            [NameInMap("EPNInstance")]
            [Validation(Required=false)]
            public List<DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance> EPNInstance { get; set; }
            public class DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance : TeaModel {
                public string CreationTime { get; set; }
                public string EPNInstanceId { get; set; }
                public string EPNInstanceName { get; set; }
                public string EPNInstanceType { get; set; }
                public string EndTime { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public string ModifyTime { get; set; }
                public string NetworkingModel { get; set; }
                public string StartTime { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
