// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class TargetServiceConfig : TeaModel {
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("modelNamePattern")]
        [Validation(Required=false)]
        public string ModelNamePattern { get; set; }

        [NameInMap("weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

    }

}
