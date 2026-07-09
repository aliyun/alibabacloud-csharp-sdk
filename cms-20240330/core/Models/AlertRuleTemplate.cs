// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTemplate : TeaModel {
        [NameInMap("alertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("applyCount")]
        [Validation(Required=false)]
        public long? ApplyCount { get; set; }

        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("datasource")]
        [Validation(Required=false)]
        public string Datasource { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public int? IsSystem { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("ruleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

        [NameInMap("scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
