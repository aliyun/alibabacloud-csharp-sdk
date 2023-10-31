// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class CreateFineTuneJobShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModel { get; set; }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public string HyperParametersShrink { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("TrainingFiles")]
        [Validation(Required=false)]
        public string TrainingFilesShrink { get; set; }

        [NameInMap("TrainingType")]
        [Validation(Required=false)]
        public string TrainingType { get; set; }

        [NameInMap("ValidationFiles")]
        [Validation(Required=false)]
        public string ValidationFilesShrink { get; set; }

    }

}
