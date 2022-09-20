// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateDetail : TeaModel {
        [NameInMap("AbandonReasons")]
        [Validation(Required=false)]
        public List<string> AbandonReasons { get; set; }

        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        [NameInMap("QuestionConfigs")]
        [Validation(Required=false)]
        public List<QuestionPlugin> QuestionConfigs { get; set; }

        [NameInMap("SharedMode")]
        [Validation(Required=false)]
        public string SharedMode { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("ViewConfigs")]
        [Validation(Required=false)]
        public TemplateDetailViewConfigs ViewConfigs { get; set; }
        public class TemplateDetailViewConfigs : TeaModel {
            [NameInMap("ViewPlugins")]
            [Validation(Required=false)]
            public List<ViewPlugin> ViewPlugins { get; set; }

        }

    }

}
