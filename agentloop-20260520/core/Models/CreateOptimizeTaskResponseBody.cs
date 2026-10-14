// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateOptimizeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the optimization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efficiency-analysis</para>
        /// </summary>
        [NameInMap("optimizeTaskName")]
        [Validation(Required=false)]
        public string OptimizeTaskName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
