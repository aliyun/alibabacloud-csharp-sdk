// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetAvailableLLMModelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;glm-5&quot;,&quot;deepseek-v3.2&quot;]</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<string> Models { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
