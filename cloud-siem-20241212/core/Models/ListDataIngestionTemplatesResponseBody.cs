// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionTemplatesResponseBody : TeaModel {
        [NameInMap("DataIngestionTemplates")]
        [Validation(Required=false)]
        public List<ListDataIngestionTemplatesResponseBodyDataIngestionTemplates> DataIngestionTemplates { get; set; }
        public class ListDataIngestionTemplatesResponseBodyDataIngestionTemplates : TeaModel {
            [NameInMap("CapacityCount")]
            [Validation(Required=false)]
            public string CapacityCount { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DataIngestionMode")]
            [Validation(Required=false)]
            public string DataIngestionMode { get; set; }

            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public string DataIngestionStatus { get; set; }

            [NameInMap("DataIngestionTemplateId")]
            [Validation(Required=false)]
            public string DataIngestionTemplateId { get; set; }

            [NameInMap("DataIngestionTemplateName")]
            [Validation(Required=false)]
            public string DataIngestionTemplateName { get; set; }

            [NameInMap("DataIngestionTemplateStatus")]
            [Validation(Required=false)]
            public string DataIngestionTemplateStatus { get; set; }

            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
