// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The content associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>春天里常见的景</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The unique ID for the request. This ID is useful for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
