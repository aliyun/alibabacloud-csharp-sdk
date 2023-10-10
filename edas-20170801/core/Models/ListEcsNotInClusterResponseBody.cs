// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about ECS instances.
        /// </summary>
        [NameInMap("EcsEntityList")]
        [Validation(Required=false)]
        public ListEcsNotInClusterResponseBodyEcsEntityList EcsEntityList { get; set; }
        public class ListEcsNotInClusterResponseBodyEcsEntityList : TeaModel {
            [NameInMap("EcsEntity")]
            [Validation(Required=false)]
            public List<ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity> EcsEntity { get; set; }
            public class ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity : TeaModel {
                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The elastic IP address (EIP) associated with the ECS instance.
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// Indicates whether the ECS instance has expired. Valid values:
                /// 
                /// *   **true**: The ECS instance has expired.
                /// *   **false**: The ECS instance has not expired.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// The private IP address of the ECS instance.
                /// </summary>
                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the ECS instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The size of memory. Unit: bytes.
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// The private IP address of the ECS instance.
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// The public IP address of the ECS instance.
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// The ID of the region where the ECS instance is located.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the ECS instance. Valid values:
                /// 
                /// *   **Pending**: The ECS instance is being created.
                /// *   **Running**: The ECS instance is running.
                /// *   **Starting**: The ECS instance is being started.
                /// *   **Stopping**: The ECS instance is being stopped.
                /// *   **Stopped**: The ECS instance is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
