// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to expand independent policy configurations. When omitted or set to true, a full compatible view is returned. When set to false, the ModelAPI Token throttling managed by Policy returns policy references and optional read-only plug-in status, and the rule body can be retrieved by calling GetPolicy.</para>
        /// </summary>
        [NameInMap("expandPolicyConfigs")]
        [Validation(Required=false)]
        public bool? ExpandPolicyConfigs { get; set; }

    }

}
