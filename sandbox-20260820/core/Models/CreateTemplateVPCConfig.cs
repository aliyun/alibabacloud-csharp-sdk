// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateVPCConfig : TeaModel {
        /// <summary>
        /// <para>The ARN of the RAM role assumed by the sandboxed container instance when accessing the VPC. Format: acs:ram::{account ID}:role/{role name}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/aliyunfcdefaultrole</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The ID of the security group used by the sandboxed container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-****</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs that the sandboxed container instance connects to. Configure vSwitches in multiple zones to improve availability.</para>
        /// </summary>
        [NameInMap("vSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC that the sandboxed container instance connects to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
