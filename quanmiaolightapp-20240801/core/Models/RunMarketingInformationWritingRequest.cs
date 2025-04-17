// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunMarketingInformationWritingRequest : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("customLimitation")]
        [Validation(Required=false)]
        public string CustomLimitation { get; set; }

        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        [NameInMap("inputExample")]
        [Validation(Required=false)]
        public string InputExample { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max
        /// qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("outputExample")]
        [Validation(Required=false)]
        public string OutputExample { get; set; }

        [NameInMap("sourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        [NameInMap("writingType")]
        [Validation(Required=false)]
        public string WritingType { get; set; }

    }

}
