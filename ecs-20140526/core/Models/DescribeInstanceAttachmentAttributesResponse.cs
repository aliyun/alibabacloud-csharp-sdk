// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAttachmentAttributesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public DescribeInstanceAttachmentAttributesResponseInstances Instances { get; set; }
        public class DescribeInstanceAttachmentAttributesResponseInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=true)]
            public List<DescribeInstanceAttachmentAttributesResponseInstancesInstance> Instance { get; set; }
            public class DescribeInstanceAttachmentAttributesResponseInstancesInstance : TeaModel {
                public string InstanceId { get; set; }
                public string PrivatePoolOptionsId { get; set; }
                public string PrivatePoolOptionsMatchCriteria { get; set; }
            }
        };

    }

}
