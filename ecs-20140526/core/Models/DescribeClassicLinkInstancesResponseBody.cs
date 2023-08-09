// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeClassicLinkInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the ClassicLink connections between the instances reside in the classic network and VPCs.
        /// </summary>
        [NameInMap("Links")]
        [Validation(Required=false)]
        public DescribeClassicLinkInstancesResponseBodyLinks Links { get; set; }
        public class DescribeClassicLinkInstancesResponseBodyLinks : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public List<DescribeClassicLinkInstancesResponseBodyLinksLink> Link { get; set; }
            public class DescribeClassicLinkInstancesResponseBodyLinksLink : TeaModel {
                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
        /// The total number of ClassicLink connections.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
