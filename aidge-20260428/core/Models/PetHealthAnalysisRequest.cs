// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PetHealthAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The list of HTTPS URLs of images to analyze. At least one accessible image must be provided.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public List<string> ImageUrl { get; set; }

        /// <summary>
        /// <para>The system prompt used to specify the response role or requirements. The value must comply with JSON string escaping rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are a professional veterinarian</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The custom analysis requirement. If not specified or set to an empty string, excrement analysis is performed by default. The value must comply with JSON string escaping rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please analyze the health condition of this pet</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
