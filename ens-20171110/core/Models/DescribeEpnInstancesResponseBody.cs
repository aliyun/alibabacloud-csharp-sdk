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
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("EPNInstanceId")]
                [Validation(Required=false)]
                public string EPNInstanceId { get; set; }

                [NameInMap("EPNInstanceName")]
                [Validation(Required=false)]
                public string EPNInstanceName { get; set; }

                [NameInMap("EPNInstanceType")]
                [Validation(Required=false)]
                public string EPNInstanceType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("NetworkingModel")]
                [Validation(Required=false)]
                public string NetworkingModel { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
