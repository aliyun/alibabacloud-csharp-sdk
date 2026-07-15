// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteGatewaySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to cascade delete security group rules is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cascade delete security group rules.</description></item>
        /// <item><description>false: Do not cascade delete security group rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cascadingDelete")]
        [Validation(Required=false)]
        public bool? CascadingDelete { get; set; }

    }

}
