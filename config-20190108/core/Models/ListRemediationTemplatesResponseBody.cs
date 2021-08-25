// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListRemediationTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RemediationTemplates")]
        [Validation(Required=false)]
        public List<ListRemediationTemplatesResponseBodyRemediationTemplates> RemediationTemplates { get; set; }
        public class ListRemediationTemplatesResponseBodyRemediationTemplates : TeaModel {
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            [NameInMap("TemplateIdentifier")]
            [Validation(Required=false)]
            public string TemplateIdentifier { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateDefinition")]
            [Validation(Required=false)]
            public string TemplateDefinition { get; set; }

        }

    }

}
