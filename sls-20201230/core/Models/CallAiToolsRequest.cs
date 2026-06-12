// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CallAiToolsRequest : TeaModel {
        /// <summary>
        /// <para>Tool parameters.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// <para>The target region.</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

    }

}
