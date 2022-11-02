// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public DescribeDefenseTemplateResponseBodyTemplate Template { get; set; }
        public class DescribeDefenseTemplateResponseBodyTemplate : TeaModel {
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

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

}
