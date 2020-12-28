// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAutoRenewAttributeResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=false)]
        public List<DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes> InstanceRenewAttributes { get; set; }
        public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes : TeaModel {
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("RenewalStatus")]
            [Validation(Required=false)]
            public string RenewalStatus { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("AutoRenewEnabled")]
            [Validation(Required=false)]
            public bool? AutoRenewEnabled { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
