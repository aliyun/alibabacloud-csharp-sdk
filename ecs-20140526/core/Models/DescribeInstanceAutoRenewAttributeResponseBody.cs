// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAutoRenewAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes InstanceRenewAttributes { get; set; }
        public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes : TeaModel {
            [NameInMap("InstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute> InstanceRenewAttribute { get; set; }
            public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute : TeaModel {
                public string PeriodUnit { get; set; }
                public int? Duration { get; set; }
                public string RenewalStatus { get; set; }
                public string InstanceId { get; set; }
                public bool? AutoRenewEnabled { get; set; }
            }
        };

    }

}
