// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunStyleWritingRequest : TeaModel {
        [NameInMap("learningSamples")]
        [Validation(Required=false)]
        public List<string> LearningSamples { get; set; }

        [NameInMap("processStage")]
        [Validation(Required=false)]
        public string ProcessStage { get; set; }

        [NameInMap("referenceMaterials")]
        [Validation(Required=false)]
        public List<string> ReferenceMaterials { get; set; }

        [NameInMap("styleFeature")]
        [Validation(Required=false)]
        public string StyleFeature { get; set; }

        [NameInMap("useSearch")]
        [Validation(Required=false)]
        public bool? UseSearch { get; set; }

        [NameInMap("writingTheme")]
        [Validation(Required=false)]
        public string WritingTheme { get; set; }

    }

}
