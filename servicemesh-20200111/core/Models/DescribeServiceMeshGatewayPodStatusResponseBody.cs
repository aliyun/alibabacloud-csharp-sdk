// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshGatewayPodStatusResponseBody : TeaModel {
        [NameInMap("ASMGatewayDetails")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshGatewayPodStatusResponseBodyASMGatewayDetails> ASMGatewayDetails { get; set; }
        public class DescribeServiceMeshGatewayPodStatusResponseBodyASMGatewayDetails : TeaModel {
            [NameInMap("ClusterID")]
            [Validation(Required=false)]
            public string ClusterID { get; set; }

            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            [NameInMap("ReadyPodNum")]
            [Validation(Required=false)]
            public long? ReadyPodNum { get; set; }

            [NameInMap("SpecPodNum")]
            [Validation(Required=false)]
            public long? SpecPodNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
