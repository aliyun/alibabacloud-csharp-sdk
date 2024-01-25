// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayIntranetLinkedVpcResponseBody : TeaModel {
        /// <summary>
        /// The private gateway ID.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// The internal endpoints.
        /// </summary>
        [NameInMap("IntranetLinkedVpcList")]
        [Validation(Required=false)]
        public List<ListGatewayIntranetLinkedVpcResponseBodyIntranetLinkedVpcList> IntranetLinkedVpcList { get; set; }
        public class ListGatewayIntranetLinkedVpcResponseBodyIntranetLinkedVpcList : TeaModel {
            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The security group ID.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The state of the private gateway.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The private gateway is being created.
            /// 
            ///     <!-- -->
            /// 
            /// *   Running
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The private gateway is running.
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
