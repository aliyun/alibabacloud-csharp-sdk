// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyOutputs> Outputs { get; set; }
        public class ValidateTemplateResponseBodyOutputs : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }
        };

    }

}
