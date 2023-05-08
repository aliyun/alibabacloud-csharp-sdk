// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshVMsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ECS instances that reside in the same VPC as the ASM instance.
        /// </summary>
        [NameInMap("VMs")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshVMsResponseBodyVMs> VMs { get; set; }
        public class DescribeServiceMeshVMsResponseBodyVMs : TeaModel {
            /// <summary>
            /// Indicates whether the ECS instance has labels.
            /// </summary>
            [NameInMap("HasTag")]
            [Validation(Required=false)]
            public bool? HasTag { get; set; }

            /// <summary>
            /// The hostname of the ECS instance.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address of the ECS instance.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The security group to which the ECS instance belongs.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public string SecurityGroupIds { get; set; }

            /// <summary>
            /// The ID of the ASM instance.
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

            /// <summary>
            /// The state of the ECS instance.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
