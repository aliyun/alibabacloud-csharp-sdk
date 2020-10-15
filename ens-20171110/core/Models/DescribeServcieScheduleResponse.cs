// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceIp")]
        [Validation(Required=true)]
        public string InstanceIp { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=true)]
        public int? InstancePort { get; set; }

        [NameInMap("Index")]
        [Validation(Required=true)]
        public int? Index { get; set; }

        [NameInMap("TcpPorts")]
        [Validation(Required=true)]
        public string TcpPorts { get; set; }

        [NameInMap("RequestRepeated")]
        [Validation(Required=true)]
        public bool? RequestRepeated { get; set; }

        [NameInMap("PodAbstractInfo")]
        [Validation(Required=true)]
        public DescribeServcieScheduleResponsePodAbstractInfo PodAbstractInfo { get; set; }
        public class DescribeServcieScheduleResponsePodAbstractInfo : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=true)]
            public bool? Name { get; set; }
            [NameInMap("ResourceScope")]
            [Validation(Required=true)]
            public bool? ResourceScope { get; set; }
            [NameInMap("ContainerService")]
            [Validation(Required=true)]
            public bool? ContainerService { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=true)]
            public bool? Namespace { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("ContainerStatuses")]
            [Validation(Required=true)]
            public DescribeServcieScheduleResponsePodAbstractInfoContainerStatuses ContainerStatuses { get; set; }
            public class DescribeServcieScheduleResponsePodAbstractInfoContainerStatuses : TeaModel {
                [NameInMap("ContainerStatus")]
                [Validation(Required=true)]
                public List<DescribeServcieScheduleResponsePodAbstractInfoContainerStatusesContainerStatus> ContainerStatus { get; set; }
                public class DescribeServcieScheduleResponsePodAbstractInfoContainerStatusesContainerStatus : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("ContainerId")]
                    [Validation(Required=true)]
                    public string ContainerId { get; set; }

                }

            }
        };

    }

}
