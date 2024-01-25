// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceDLinkRequest : TeaModel {
        /// <summary>
        /// The CIDR blocks of the clients that you want to connect to. After this parameter is specified, the CIDR blocks are added to the back-to-origin route of the server. Either this parameter or the VSwitchIdList parameter can be used to determine CIDR blocks.
        /// </summary>
        [NameInMap("DestinationCIDRs")]
        [Validation(Required=false)]
        public string DestinationCIDRs { get; set; }

        /// <summary>
        /// The ID of the security group to which the Elastic Compute Service (ECS) instance belongs.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The ID of the peer primary vSwitch. After this parameter is specified, an elastic network interface (ENI) is created in the VSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The vSwitches of the clients that you want to connect to. After this parameter is specified, the CIDR blocks of these vSwitches are added to the back-to-origin route of the server.
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

    }

}
