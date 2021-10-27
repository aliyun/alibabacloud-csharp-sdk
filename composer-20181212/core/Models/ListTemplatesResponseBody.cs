// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("TemplateConnector")]
            [Validation(Required=false)]
            public string TemplateConnector { get; set; }

            [NameInMap("TemplateCreator")]
            [Validation(Required=false)]
            public string TemplateCreator { get; set; }

            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateLocale")]
            [Validation(Required=false)]
            public string TemplateLocale { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateOverview")]
            [Validation(Required=false)]
            public string TemplateOverview { get; set; }

            [NameInMap("TemplateSummary")]
            [Validation(Required=false)]
            public string TemplateSummary { get; set; }

            [NameInMap("TemplateSummaryEn")]
            [Validation(Required=false)]
            public string TemplateSummaryEn { get; set; }

            [NameInMap("TemplateTag")]
            [Validation(Required=false)]
            public string TemplateTag { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public int? TemplateVersion { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
