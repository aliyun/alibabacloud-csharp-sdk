// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewaySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>Description of the security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>商品中心访问安全组</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Port ranges.</para>
        /// </summary>
        [NameInMap("portRanges")]
        [Validation(Required=false)]
        public List<string> PortRanges { get; set; }

        /// <summary>
        /// <para>Security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-wz929kxhcdp****</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
