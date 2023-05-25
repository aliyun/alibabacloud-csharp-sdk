// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAttachmentAttributesResponseBody : TeaModel {
        /// <summary>
        /// Details about the private pools that the instances match.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceAttachmentAttributesResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceAttachmentAttributesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttachmentAttributesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstanceAttachmentAttributesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the private pool. If the value of `PrivatePoolOptionsMatchCriteria` is `Open`, the value of PrivatePoolOptionsId is the ID of the private pool that is automatically matched to the instance.
                /// </summary>
                [NameInMap("PrivatePoolOptionsId")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsId { get; set; }

                /// <summary>
                /// The match mode of the private pool. Valid values:
                /// 
                /// *   Open: open private pool. Instances automatically match an open private pool.
                /// *   Target: specified private pool. Instances match a specified private pool.
                /// *   None: no private pool. Instances do not use private pools.
                /// </summary>
                [NameInMap("PrivatePoolOptionsMatchCriteria")]
                [Validation(Required=false)]
                public string PrivatePoolOptionsMatchCriteria { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
