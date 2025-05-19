// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateLLMConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>llm_config1</para>
        /// </summary>
        [NameInMap("LLMConfigId")]
        [Validation(Required=false)]
        public string LLMConfigId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
