// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteGatewaySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>Whether to cascade delete the security group rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cascadingDelete")]
        [Validation(Required=false)]
        public bool? CascadingDelete { get; set; }

    }

}
