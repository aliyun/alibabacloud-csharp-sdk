// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerSandboxRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The RAM role that grants the required permissions to the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::xxxx:role/xxx_role</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The VPC configuration.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public InnerSandboxRuntimeConfigVpcConfig VpcConfig { get; set; }
        public class InnerSandboxRuntimeConfigVpcConfig : TeaModel {
            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxxx</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// </summary>
            [NameInMap("vSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxx</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
