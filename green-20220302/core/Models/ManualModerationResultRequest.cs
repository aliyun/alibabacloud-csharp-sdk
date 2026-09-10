// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The set of parameters required by the service, in JSON string format.</para>
        /// <list type="bullet">
        /// <item><description>taskId: The task ID returned when the task was submitted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;taskId\&quot;:\&quot;m_tx_8oaprwnGUKuuLYNwV21JRf-VQjzQX3\&quot;</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
