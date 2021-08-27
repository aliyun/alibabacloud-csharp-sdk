// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Topologys")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyTopologys Topologys { get; set; }
        public class DescribeInstanceTopologyResponseBodyTopologys : TeaModel {
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyTopologysTopology> Topology { get; set; }
            public class DescribeInstanceTopologyResponseBodyTopologysTopology : TeaModel {
                public string HostId { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
