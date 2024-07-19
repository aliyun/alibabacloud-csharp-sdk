// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeResourceDLinkResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the secondary vSwitches that are directly connected.
        /// </summary>
        [NameInMap("AuxVSwitchList")]
        [Validation(Required=false)]
        public List<string> AuxVSwitchList { get; set; }

        /// <summary>
        /// The CIDR blocks of the clients that you want to connect to. After this parameter is specified, the CIDR blocks are added to the back-to-origin route of the server. Either this parameter or the VSwitchIdList parameter can be used to determine CIDR blocks.
        /// </summary>
        [NameInMap("DestinationCIDRs")]
        [Validation(Required=false)]
        public string DestinationCIDRs { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the security group that is directly connected.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The ID of the primary vSwitch that is directly connected.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC that is directly connected.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
