// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CustomExtractionStrategy : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("extractionPrompt")]
        [Validation(Required=false)]
        public string ExtractionPrompt { get; set; }

        [NameInMap("strategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("strategyType")]
        [Validation(Required=false)]
        public string StrategyType { get; set; }

        [NameInMap("updatePrompt")]
        [Validation(Required=false)]
        public string UpdatePrompt { get; set; }

    }

}
