// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RevokeRCSecurityGroupPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the security group rules that you want to delete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ingress</b>: inbound security group rules.</description></item>
        /// <item><description><b>egress</b>: outbound security group rules.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify security group rules only in the same direction in a request.</para>
        /// </remarks>
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
        /// <para>The IDs of the security group rules that you want to delete.</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleIdList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupRuleIdList { get; set; }

    }

}
