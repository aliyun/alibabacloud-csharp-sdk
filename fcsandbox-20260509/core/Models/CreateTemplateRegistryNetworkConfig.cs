// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateRegistryNetworkConfig : TeaModel {
        /// <summary>
        /// <para>The ID of the security group where the image repository resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1gx7yj8ud5mabcde</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch where the image repository resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnlk4jl2abcde</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the image repository resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1mwrqm3wkq7abcde</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
