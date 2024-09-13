// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleResponseBody : TeaModel {
        /// <summary>
        /// The index number of the scheduled virtual device (pod).
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// The ID of the scheduled instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the scheduled instance.
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// The start port of the scheduled instance.
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// The summary information about the scheduled virtual device.
        /// </summary>
        [NameInMap("PodAbstractInfo")]
        [Validation(Required=false)]
        public DescribeServcieScheduleResponseBodyPodAbstractInfo PodAbstractInfo { get; set; }
        public class DescribeServcieScheduleResponseBodyPodAbstractInfo : TeaModel {
            /// <summary>
            /// The name of the container service.
            /// </summary>
            [NameInMap("ContainerService")]
            [Validation(Required=false)]
            public bool? ContainerService { get; set; }

            /// <summary>
            /// The information about the container.
            /// </summary>
            [NameInMap("ContainerStatuses")]
            [Validation(Required=false)]
            public DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses ContainerStatuses { get; set; }
            public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses : TeaModel {
                [NameInMap("ContainerStatus")]
                [Validation(Required=false)]
                public List<DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus> ContainerStatus { get; set; }
                public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus : TeaModel {
                    /// <summary>
                    /// The ID of the container.
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    /// <summary>
                    /// The name of the container.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public bool? Name { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public bool? Namespace { get; set; }

            /// <summary>
            /// The pod scope.
            /// </summary>
            [NameInMap("ResourceScope")]
            [Validation(Required=false)]
            public bool? ResourceScope { get; set; }

            /// <summary>
            /// The status of the pod.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is repeated.
        /// </summary>
        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public bool? RequestRepeated { get; set; }

        /// <summary>
        /// The TCP port range of the scheduled instance or container. The value is in the ${from}-$-{to} format. Example: 80-88.
        /// </summary>
        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public string TcpPorts { get; set; }

    }

}
