// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunMarketingInformationWritingRequest : TeaModel {
        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("sourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        [NameInMap("writingType")]
        [Validation(Required=false)]
        public string WritingType { get; set; }

    }

}
