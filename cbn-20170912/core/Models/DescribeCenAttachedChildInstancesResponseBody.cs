// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the network instances.
        /// </summary>
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstancesResponseBodyChildInstances ChildInstances { get; set; }
        public class DescribeCenAttachedChildInstancesResponseBodyChildInstances : TeaModel {
            [NameInMap("ChildInstance")]
            [Validation(Required=false)]
            public List<DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance> ChildInstance { get; set; }
            public class DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance : TeaModel {
                /// <summary>
                /// The ID of the CEN instance.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The time when the network instance was attached to the CEN instance.
                /// 
                /// The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ChildInstanceAttachTime")]
                [Validation(Required=false)]
                public string ChildInstanceAttachTime { get; set; }

                /// <summary>
                /// The ID of the network instance.
                /// </summary>
                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the network instance belongs.
                /// </summary>
                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                /// <summary>
                /// The ID of the region where the network instance is deployed.
                /// </summary>
                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                /// <summary>
                /// The type of the network instance. Valid values:
                /// 
                /// *   **VPC**: VPC
                /// *   **VBR**: VBR
                /// *   **CCN**: CCN instance
                /// </summary>
                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                /// <summary>
                /// The status of the network instance. Valid values:
                /// 
                /// *   **Attaching**: The network instance is being created on the transit router.
                /// *   **Attached**: The network instance has been created on the transit router.
                /// *   **Detaching**: The network instance is being deleted from the transit router.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
