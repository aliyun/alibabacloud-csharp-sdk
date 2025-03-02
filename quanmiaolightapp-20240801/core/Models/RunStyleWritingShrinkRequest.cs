// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunStyleWritingShrinkRequest : TeaModel {
        [NameInMap("learningSamples")]
        [Validation(Required=false)]
        public string LearningSamplesShrink { get; set; }

        [NameInMap("processStage")]
        [Validation(Required=false)]
        public string ProcessStage { get; set; }

        [NameInMap("referenceMaterials")]
        [Validation(Required=false)]
        public string ReferenceMaterialsShrink { get; set; }

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
