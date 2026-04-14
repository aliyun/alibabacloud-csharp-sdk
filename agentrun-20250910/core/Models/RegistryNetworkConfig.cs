// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RegistryNetworkConfig : TeaModel {
        /// <summary>
        /// <para>镜像仓库的安全组ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>镜像仓库所在的交换机ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>镜像仓库所在的VPC ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
