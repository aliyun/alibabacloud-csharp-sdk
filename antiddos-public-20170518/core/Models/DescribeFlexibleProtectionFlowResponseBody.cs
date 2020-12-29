// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeFlexibleProtectionFlowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<DescribeFlexibleProtectionFlowResponseBodyFlows> Flows { get; set; }
        public class DescribeFlexibleProtectionFlowResponseBodyFlows : TeaModel {
            [NameInMap("UsedFlow")]
            [Validation(Required=false)]
            public float? UsedFlow { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("AddFlow")]
            [Validation(Required=false)]
            public float? AddFlow { get; set; }

            [NameInMap("UseableFlow")]
            [Validation(Required=false)]
            public float? UseableFlow { get; set; }

        }

    }

}
