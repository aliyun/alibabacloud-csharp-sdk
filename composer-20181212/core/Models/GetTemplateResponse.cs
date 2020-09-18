// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetTemplateResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

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

        [NameInMap("Definition")]
        [Validation(Required=true)]
        public string Definition { get; set; }

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

        [NameInMap("TemplateOverview")]
        [Validation(Required=true)]
        public string TemplateOverview { get; set; }

        [NameInMap("TemplateCreator")]
        [Validation(Required=true)]
        public string TemplateCreator { get; set; }

    }

}
