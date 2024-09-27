// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the topology.</para>
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
                /// <para>The ID of the host where the ECS instance resides. This parameter is encrypted and cannot match the ID of the ECS instance. However, if the values of this parameter for different ECS instances are the same, the ECS instances reside on the same host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZWNobyBo****</para>
                /// </summary>
                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
