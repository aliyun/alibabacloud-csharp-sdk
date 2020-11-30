// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeOnDemandInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public string Total { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<DescribeOnDemandInstanceResponseInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceResponseInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

            [NameInMap("DefenseStatus")]
            [Validation(Required=true)]
            public string DefenseStatus { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=true)]
            public string RegionId { get; set; }

            [NameInMap("Ipnet")]
            [Validation(Required=true)]
            public List<string> Ipnet { get; set; }

        }

    }

}
