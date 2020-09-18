// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListTemplatesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=true)]
        public List<ListTemplatesResponseTemplates> Templates { get; set; }
        public class ListTemplatesResponseTemplates : TeaModel {
            [NameInMap("TemplateId")]
            [Validation(Required=true)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=true)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateDescription")]
            [Validation(Required=true)]
            public string TemplateDescription { get; set; }

            [NameInMap("TemplateTag")]
            [Validation(Required=true)]
            public string TemplateTag { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

            [NameInMap("TemplateConnector")]
            [Validation(Required=true)]
            public string TemplateConnector { get; set; }

            [NameInMap("TemplateSummary")]
            [Validation(Required=true)]
            public string TemplateSummary { get; set; }

            [NameInMap("TemplateSummaryEn")]
            [Validation(Required=true)]
            public string TemplateSummaryEn { get; set; }

            [NameInMap("TemplateLocale")]
            [Validation(Required=true)]
            public string TemplateLocale { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=true)]
            public int? TemplateVersion { get; set; }

            [NameInMap("TemplateCreator")]
            [Validation(Required=true)]
            public string TemplateCreator { get; set; }

            [NameInMap("TemplateOverview")]
            [Validation(Required=true)]
            public string TemplateOverview { get; set; }

        }

    }

}
