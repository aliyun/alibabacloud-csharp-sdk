// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateResponseBody : TeaModel {
        [NameInMap("RemediationTemplates")]
        [Validation(Required=false)]
        public List<GetRemediationTemplateResponseBodyRemediationTemplates> RemediationTemplates { get; set; }
        public class GetRemediationTemplateResponseBodyRemediationTemplates : TeaModel {
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            [NameInMap("TemplateDefinition")]
            [Validation(Required=false)]
            public string TemplateDefinition { get; set; }

            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            [NameInMap("TemplateIdentifier")]
            [Validation(Required=false)]
            public string TemplateIdentifier { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
