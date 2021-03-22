// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeActivationsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("ActivationList")]
        [Validation(Required=false)]
        public List<DescribeActivationsResponseBodyActivationList> ActivationList { get; set; }
        public class DescribeActivationsResponseBodyActivationList : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DeregisteredCount")]
            [Validation(Required=false)]
            public int? DeregisteredCount { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RegisteredCount")]
            [Validation(Required=false)]
            public int? RegisteredCount { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            [NameInMap("IpAddressRange")]
            [Validation(Required=false)]
            public string IpAddressRange { get; set; }

            [NameInMap("TimeToLiveInHours")]
            [Validation(Required=false)]
            public long? TimeToLiveInHours { get; set; }

            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

        }

    }

}
