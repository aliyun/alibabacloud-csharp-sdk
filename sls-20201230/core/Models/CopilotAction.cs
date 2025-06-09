// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CopilotAction : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<CopilotActionParameters> Parameters { get; set; }
        public class CopilotActionParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public string Required { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("queryMaxLength")]
        [Validation(Required=false)]
        public long? QueryMaxLength { get; set; }

        [NameInMap("queryTemplate")]
        [Validation(Required=false)]
        public string QueryTemplate { get; set; }

        [NameInMap("queryTemplateParameters")]
        [Validation(Required=false)]
        public List<CopilotActionQueryTemplateParameters> QueryTemplateParameters { get; set; }
        public class CopilotActionQueryTemplateParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public string Required { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
