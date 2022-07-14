// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySmarttagTemplateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public QuerySmarttagTemplateListResponseBodyTemplates Templates { get; set; }
        public class QuerySmarttagTemplateListResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<QuerySmarttagTemplateListResponseBodyTemplatesTemplate> Template { get; set; }
            public class QuerySmarttagTemplateListResponseBodyTemplatesTemplate : TeaModel {
                public string AnalyseTypes { get; set; }
                public string FaceCategoryIds { get; set; }
                public string FaceCustomParamsConfig { get; set; }
                public string Industry { get; set; }
                public bool? IsDefault { get; set; }
                public string KeywordConfig { get; set; }
                public string KnowledgeConfig { get; set; }
                public string LabelType { get; set; }
                public string LabelVersion { get; set; }
                public string Scene { get; set; }
                public string TemplateId { get; set; }
                public string TemplateName { get; set; }
            }
        };

    }

}
