// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateLLMConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the LLM configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_config1</para>
        /// </summary>
        [NameInMap("LLMConfigId")]
        [Validation(Required=false)]
        public string LLMConfigId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD19A0E2-0DC8-5EAA-867D-00C813F553F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
