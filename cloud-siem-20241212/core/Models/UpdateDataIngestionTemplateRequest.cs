// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataIngestionTemplateRequest : TeaModel {
        [NameInMap("DataIngestionStatus")]
        [Validation(Required=false)]
        public string DataIngestionStatus { get; set; }

        [NameInMap("DataIngestionTemplateId")]
        [Validation(Required=false)]
        public string DataIngestionTemplateId { get; set; }

        [NameInMap("DataIngestionTemplateName")]
        [Validation(Required=false)]
        public string DataIngestionTemplateName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
