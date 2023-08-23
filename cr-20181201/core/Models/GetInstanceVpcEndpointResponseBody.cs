// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Indicates whether the access control list (ACL) feature is enabled. Valid values:
        /// 
        /// *   `true`: The ACL feature is enabled.
        /// *   `false`: The ACL feature is disabled.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The VPCs in which the instance is deployed.
        /// </summary>
        [NameInMap("LinkedVpcs")]
        [Validation(Required=false)]
        public List<GetInstanceVpcEndpointResponseBodyLinkedVpcs> LinkedVpcs { get; set; }
        public class GetInstanceVpcEndpointResponseBodyLinkedVpcs : TeaModel {
            /// <summary>
            /// Indicates whether the default ACL is used.
            /// </summary>
            [NameInMap("DefaultAccess")]
            [Validation(Required=false)]
            public bool? DefaultAccess { get; set; }

            /// <summary>
            /// IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The status of the VPC. Valid values:
            /// 
            /// *   `CREATING`: The VPC is being created.
            /// *   `RUNNING`: The VPC is running.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// VPC ID
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
