// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to expand independent policy configurations. If omitted or set to true, a complete compatibility view is returned. If set to false, the ModelAPI token throttling managed by the policy returns a policy reference and an optional read-only plugin status. You can use GetPolicy to retrieve the rule body.</para>
        /// </summary>
        [NameInMap("expandPolicyConfigs")]
        [Validation(Required=false)]
        public bool? ExpandPolicyConfigs { get; set; }

    }

}
