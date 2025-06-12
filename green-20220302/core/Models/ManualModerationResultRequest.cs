// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>Set of parameters required by the service, in JSON string format.</para>
        /// <list type="bullet">
        /// <item><description>TaskId: The task ID returned when the task was submitted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TaskId\&quot;:\&quot;e5f2d886-4c23-440d-999c-bd98acde11b6\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
