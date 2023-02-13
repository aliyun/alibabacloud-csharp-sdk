// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the topology.
        /// </summary>
        [NameInMap("Topologys")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyTopologys Topologys { get; set; }
        public class DescribeInstanceTopologyResponseBodyTopologys : TeaModel {
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyTopologysTopology> Topology { get; set; }
            public class DescribeInstanceTopologyResponseBodyTopologysTopology : TeaModel {
                /// <summary>
                /// The ID of the host where the ECS instance is deployed. This parameter is encrypted and cannot match the ID of the instance. However, if the values of this parameter for different ECS instances are the same, the ECS instances are deployed on the same host.
                /// </summary>
                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
