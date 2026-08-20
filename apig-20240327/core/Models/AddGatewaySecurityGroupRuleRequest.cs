// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewaySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product center access security group</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The port ranges.</para>
        /// </summary>
        [NameInMap("portRanges")]
        [Validation(Required=false)]
        public List<string> PortRanges { get; set; }

        /// <summary>
        /// <para>The security group ID. This parameter is required. The specified security group must be different from the security group associated with the gateway. Otherwise, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-wz929kxhcdp****</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
