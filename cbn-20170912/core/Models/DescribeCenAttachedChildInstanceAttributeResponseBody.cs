// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstanceAttributeResponseBody : TeaModel {
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
        /// The name of the network instance.
        /// </summary>
        [NameInMap("ChildInstanceName")]
        [Validation(Required=false)]
        public string ChildInstanceName { get; set; }

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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the network instance is attached to the CEN instance. Valid values:
        /// 
        /// *   **Attaching**: being attached to the CEN instance.
        /// *   **Attached**: attached to the CEN instance.
        /// *   **Detaching**: being detached from the CEN instance.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
