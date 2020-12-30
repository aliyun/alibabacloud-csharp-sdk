// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
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
            public Dictionary<string, object> Tags { get; set; }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            [NameInMap("Popularity")]
            [Validation(Required=false)]
            public int? Popularity { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("TotalExecutionCount")]
            [Validation(Required=false)]
            public int? TotalExecutionCount { get; set; }

            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("HasTrigger")]
            [Validation(Required=false)]
            public bool? HasTrigger { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

        }

    }

}
