// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseTemplateRequest : TeaModel {
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateOrigin")]
        [Validation(Required=false)]
        public string TemplateOrigin { get; set; }

        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public int? TemplateStatus { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
