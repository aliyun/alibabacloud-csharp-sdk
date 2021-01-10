// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportClriskTemplateRequest : TeaModel {
        [NameInMap("Imports")]
        [Validation(Required=false)]
        public List<ImportClriskTemplateRequestImports> Imports { get; set; }
        public class ImportClriskTemplateRequestImports : TeaModel {
            [NameInMap("DataNodes")]
            [Validation(Required=false)]
            public string DataNodes { get; set; }

            [NameInMap("IsModify")]
            [Validation(Required=false)]
            public bool? IsModify { get; set; }

            [NameInMap("ModelCode")]
            [Validation(Required=false)]
            public string ModelCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owners")]
            [Validation(Required=false)]
            public string Owners { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            [NameInMap("RuleCodes")]
            [Validation(Required=false)]
            public string RuleCodes { get; set; }

            [NameInMap("RuleNames")]
            [Validation(Required=false)]
            public string RuleNames { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateRuleCodes")]
            [Validation(Required=false)]
            public string TemplateRuleCodes { get; set; }

        }

    }

}
