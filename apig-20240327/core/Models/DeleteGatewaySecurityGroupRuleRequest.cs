// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteGatewaySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the cascaded security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cascadingDelete")]
        [Validation(Required=false)]
        public bool? CascadingDelete { get; set; }

    }

}
