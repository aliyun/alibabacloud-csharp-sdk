// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;taskId&quot;:&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;,&quot;serviceId&quot;:&quot;ggxw4lnjuz@f2fd3a6265a254a052afb&quot;,&quot;taskType&quot;:&quot;live_debug_log_probe&quot;,&quot;ip&quot;:&quot;10.0.0.1&quot;,&quot;extraInfo&quot;:&quot;{\&quot;probeType\&quot;:\&quot;LOG\&quot;,\&quot;language\&quot;:\&quot;java\&quot;}&quot;}</para>
        /// </summary>
        [NameInMap("serviceTask")]
        [Validation(Required=false)]
        public Dictionary<string, object> ServiceTask { get; set; }

    }

}
