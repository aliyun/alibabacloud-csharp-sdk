// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateAndPublishAgentSelectiveShrinkRequest : TeaModel {
        [NameInMap("applicationConfig")]
        [Validation(Required=false)]
        public string ApplicationConfigShrink { get; set; }

        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sampleLibrary")]
        [Validation(Required=false)]
        public string SampleLibraryShrink { get; set; }

    }

}
