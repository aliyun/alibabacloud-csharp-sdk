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

        [NameInMap("Topologys")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyTopologys Topologys { get; set; }
        public class DescribeInstanceTopologyResponseBodyTopologys : TeaModel {
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyTopologysTopology> Topology { get; set; }
            public class DescribeInstanceTopologyResponseBodyTopologysTopology : TeaModel {
                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
