// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAttachmentAttributesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceAttachmentAttributesResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceAttachmentAttributesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttachmentAttributesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstanceAttachmentAttributesResponseBodyInstancesInstance : TeaModel {
                public string InstanceId { get; set; }
                public string PrivatePoolOptionsMatchCriteria { get; set; }
                public string PrivatePoolOptionsId { get; set; }
            }
        };

    }

}
