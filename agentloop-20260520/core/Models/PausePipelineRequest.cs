// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class PausePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The reason for pausing the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual maintenance</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
