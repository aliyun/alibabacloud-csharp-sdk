// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateTemplateResponseBodyTemplate Template { get; set; }
        public class UpdateTemplateResponseBodyTemplate : TeaModel {
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }
            [NameInMap("HasTrigger")]
            [Validation(Required=false)]
            public bool? HasTrigger { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }
        };

    }

}
