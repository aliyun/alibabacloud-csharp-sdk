// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RegistryNetworkConfig : TeaModel {
        /// <summary>
        /// <para>The ID of the security group that can be used to connect to the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that can be used to connect to the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) that can be used to connect to the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
