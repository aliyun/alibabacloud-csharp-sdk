// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConvertFlowDSLRequest : TeaModel {
        /// <summary>
        /// <para>The request body for the conversion.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ConvertFlowDSLInput Body { get; set; }

    }

}
