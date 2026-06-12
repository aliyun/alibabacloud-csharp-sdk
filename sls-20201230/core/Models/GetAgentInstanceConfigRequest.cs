// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAgentInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The owner of the process-level configuration.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

    }

}
