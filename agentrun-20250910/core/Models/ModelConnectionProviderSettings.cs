// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelConnectionProviderSettings : TeaModel {
        /// <summary>
        /// <para>The default API base URL for the model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://api.openai.com/v1">https://api.openai.com/v1</a></para>
        /// </summary>
        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>The list of model names supported by this connection.</para>
        /// </summary>
        [NameInMap("modelNames")]
        [Validation(Required=false)]
        public List<string> ModelNames { get; set; }

    }

}
