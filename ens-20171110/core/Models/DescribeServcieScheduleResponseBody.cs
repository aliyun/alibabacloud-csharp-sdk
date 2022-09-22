// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleResponseBody : TeaModel {
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        [NameInMap("PodAbstractInfo")]
        [Validation(Required=false)]
        public DescribeServcieScheduleResponseBodyPodAbstractInfo PodAbstractInfo { get; set; }
        public class DescribeServcieScheduleResponseBodyPodAbstractInfo : TeaModel {
            [NameInMap("ContainerService")]
            [Validation(Required=false)]
            public bool? ContainerService { get; set; }

            [NameInMap("ContainerStatuses")]
            [Validation(Required=false)]
            public DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses ContainerStatuses { get; set; }
            public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses : TeaModel {
                [NameInMap("ContainerStatus")]
                [Validation(Required=false)]
                public List<DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus> ContainerStatus { get; set; }
                public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus : TeaModel {
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public bool? Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public bool? Namespace { get; set; }

            [NameInMap("ResourceScope")]
            [Validation(Required=false)]
            public bool? ResourceScope { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public bool? RequestRepeated { get; set; }

        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public string TcpPorts { get; set; }

    }

}
