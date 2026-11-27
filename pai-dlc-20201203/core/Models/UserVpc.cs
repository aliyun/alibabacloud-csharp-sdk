// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UserVpc : TeaModel {
        /// <summary>
        /// <para>The default route configuration. Valid values: eth0 and eth1. Currently, this parameter is used only in general-purpose computing 1.0 scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eth1</para>
        /// </summary>
        [NameInMap("DefaultRoute")]
        [Validation(Required=false)]
        public string DefaultRoute { get; set; }

        /// <summary>
        /// <para>The secondary CIDR block (route configuration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   &quot;192.168.0.0/24&quot;,
        ///   &quot;192.168.1.0/24&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("ExtendedCIDRs")]
        [Validation(Required=false)]
        public List<string> ExtendedCIDRs { get; set; }

        /// <summary>
        /// <para>The role chain configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;roleType&quot;:&quot;service&quot;,
        ///     &quot;roleArn&quot;:&quot;acs:ram::service account UID:role/roletoassumecustomerrole&quot;,
        ///     &quot;assumeRoleFor&quot;: &quot;service account UID&quot;
        ///   },
        ///   {
        ///     &quot;roleType&quot;:&quot;service&quot;,
        ///     &quot;roleArn&quot;:&quot;acs:ram::end user UID:role/user-role&quot;,
        ///     &quot;assumeRoleFor&quot;:&quot;end user UID&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("RoleChain")]
        [Validation(Required=false)]
        public string RoleChain { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxx</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>vSwitch ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxx</para>
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// <para>Vpc ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
