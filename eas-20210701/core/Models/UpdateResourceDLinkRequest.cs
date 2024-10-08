// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceDLinkRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR blocks of the clients that you want to connect to. After this parameter is specified, the CIDR blocks are added to the back-to-origin route of the server. Either this parameter or the VSwitchIdList parameter can be used to determine CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72.16.0.0/16</para>
        /// </summary>
        [NameInMap("DestinationCIDRs")]
        [Validation(Required=false)]
        public string DestinationCIDRs { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the Elastic Compute Service (ECS) instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp149cedsfx2rfspd2d</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the peer primary vSwitch. After this parameter is specified, an elastic network interface (ENI) is created in the VSwitch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66uio7md****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The vSwitches of the clients that you want to connect to. After this parameter is specified, the CIDR blocks of these vSwitches are added to the back-to-origin route of the server.</para>
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

    }

}
