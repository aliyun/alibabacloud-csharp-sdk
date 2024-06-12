// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateResponseBody : TeaModel {
        /// <summary>
        /// The information about the automatic remediation template.
        /// </summary>
        [NameInMap("RemediationTemplates")]
        [Validation(Required=false)]
        public List<GetRemediationTemplateResponseBodyRemediationTemplates> RemediationTemplates { get; set; }
        public class GetRemediationTemplateResponseBodyRemediationTemplates : TeaModel {
            /// <summary>
            /// The ID of the supported rule template.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

            /// <summary>
            /// The type of the automatic remediation template. The value is set to OOS.
            /// </summary>
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            /// <summary>
            /// The parameters of the automatic remediation template.
            /// </summary>
            [NameInMap("TemplateDefinition")]
            [Validation(Required=false)]
            public string TemplateDefinition { get; set; }

            /// <summary>
            /// The description of the automatic remediation template.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// The ID of the automatic remediation template.
            /// </summary>
            [NameInMap("TemplateIdentifier")]
            [Validation(Required=false)]
            public string TemplateIdentifier { get; set; }

            /// <summary>
            /// The name of the automatic remediation template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
