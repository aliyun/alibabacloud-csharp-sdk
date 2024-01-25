// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeResourceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster to which the resource group belongs.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The total number of CPU cores.
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// The time when the resource group was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The additional information, such as the connection status of a virtual private cloud (VPC) and the log status of Log Service.
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// The total number of GPUs.
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public int? GpuCount { get; set; }

        /// <summary>
        /// The total number of instances in the resource group.
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the resource group owner.
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public string OwnerUid { get; set; }

        /// <summary>
        /// The total number of pay-as-you-go instances in the resource group.
        /// </summary>
        [NameInMap("PostPaidInstanceCount")]
        [Validation(Required=false)]
        public int? PostPaidInstanceCount { get; set; }

        /// <summary>
        /// The total number of subscription instances in the resource group.
        /// </summary>
        [NameInMap("PrePaidInstanceCount")]
        [Validation(Required=false)]
        public int? PrePaidInstanceCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the Elastic Algorithm Service (EAS) resource.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The name of the EAS resource.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// - Dedicated
        /// - SelfManaged
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The state of the resource group.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the resource group was last updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
