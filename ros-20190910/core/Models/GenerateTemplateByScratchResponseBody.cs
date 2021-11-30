// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplateByScratchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<GenerateTemplateByScratchResponseBodyResourcesToImport> ResourcesToImport { get; set; }
        public class GenerateTemplateByScratchResponseBodyResourcesToImport : TeaModel {
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceIdentifier { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

    }

}
