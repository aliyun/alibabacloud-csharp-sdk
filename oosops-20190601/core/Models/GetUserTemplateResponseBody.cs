// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class GetUserTemplateResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetUserTemplateResponseBodyTemplate Template { get; set; }
        public class GetUserTemplateResponseBodyTemplate : TeaModel {
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

    }

}
