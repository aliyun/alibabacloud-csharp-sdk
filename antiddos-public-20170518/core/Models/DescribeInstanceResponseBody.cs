// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstanceList InstanceList { get; set; }
        public class DescribeInstanceResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyInstanceListInstance> Instance { get; set; }
            public class DescribeInstanceResponseBodyInstanceListInstance : TeaModel {
                public int? BlackholeThreshold { get; set; }
                public int? DefenseBpsThreshold { get; set; }
                public int? DefensePpsThreshold { get; set; }
                public int? ElasticThreshold { get; set; }
                public string InstanceId { get; set; }
                public string InstanceIp { get; set; }
                public string InstanceName { get; set; }
                public string InstanceStatus { get; set; }
                public string InstanceType { get; set; }
                public string IpVersion { get; set; }
                public bool? IsBgppack { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
