// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AuthorizeRCSecurityGroupPermissionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ingress</b>: the inbound security group rule.</description></item>
        /// <item><description><b>egress</b>: the outbound security group rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ingress</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze27hs990o2hn9****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The information about the security group.</para>
        /// </summary>
        [NameInMap("SecurityGroupPermissions")]
        [Validation(Required=false)]
        public string SecurityGroupPermissionsShrink { get; set; }

    }

}
