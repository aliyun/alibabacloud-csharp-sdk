// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("VirtualBorderRouterForPhysicalConnectionSet")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet> VirtualBorderRouterForPhysicalConnectionSet { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            [NameInMap("RecoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

            [NameInMap("TerminationTime")]
            [Validation(Required=false)]
            public string TerminationTime { get; set; }

            [NameInMap("ActivationTime")]
            [Validation(Required=false)]
            public string ActivationTime { get; set; }

            [NameInMap("VbrOwnerUid")]
            [Validation(Required=false)]
            public long? VbrOwnerUid { get; set; }

            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public int? VlanId { get; set; }

        }

    }

}
