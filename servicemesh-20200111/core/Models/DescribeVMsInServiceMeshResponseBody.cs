// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVMsInServiceMeshResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The VMs that are added to the ASM instance.
        /// </summary>
        [NameInMap("VMs")]
        [Validation(Required=false)]
        public List<DescribeVMsInServiceMeshResponseBodyVMs> VMs { get; set; }
        public class DescribeVMsInServiceMeshResponseBodyVMs : TeaModel {
            /// <summary>
            /// Indicates whether the VM has labels.
            /// </summary>
            [NameInMap("HasTag")]
            [Validation(Required=false)]
            public bool? HasTag { get; set; }

            /// <summary>
            /// The host name of the VM.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the VM.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address of the VM.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The security group to which the VM belongs.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public string SecurityGroupIds { get; set; }

            /// <summary>
            /// The status of the VM.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
