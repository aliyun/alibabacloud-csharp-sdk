// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to expand independent policy configurations. If this parameter is omitted or set to true, a fully compatible view is returned. If this parameter is set to false, policy references and optional read-only plug-in statuses are returned for Model API token throttling managed by policies, and the rule body can be retrieved by calling GetPolicy.</para>
        /// </summary>
        [NameInMap("expandPolicyConfigs")]
        [Validation(Required=false)]
        public bool? ExpandPolicyConfigs { get; set; }

    }

}
