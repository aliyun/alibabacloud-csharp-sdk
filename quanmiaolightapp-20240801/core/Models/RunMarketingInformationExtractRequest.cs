// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunMarketingInformationExtractRequest : TeaModel {
        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        [NameInMap("extractType")]
        [Validation(Required=false)]
        public string ExtractType { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("sourceMaterials")]
        [Validation(Required=false)]
        public List<string> SourceMaterials { get; set; }

    }

}
