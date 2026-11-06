// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourceTemplatesResponseBody : TeaModel {
        [NameInMap("DataSourceTemplates")]
        [Validation(Required=false)]
        public List<ListDataSourceTemplatesResponseBodyDataSourceTemplates> DataSourceTemplates { get; set; }
        public class ListDataSourceTemplatesResponseBodyDataSourceTemplates : TeaModel {
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DataSourceFrom")]
            [Validation(Required=false)]
            public string DataSourceFrom { get; set; }

            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            [NameInMap("DataSourceRecognizer")]
            [Validation(Required=false)]
            public string DataSourceRecognizer { get; set; }

            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            [NameInMap("DataSourceTemplateName")]
            [Validation(Required=false)]
            public string DataSourceTemplateName { get; set; }

            [NameInMap("LogProjectPattern")]
            [Validation(Required=false)]
            public string LogProjectPattern { get; set; }

            [NameInMap("LogRegionIds")]
            [Validation(Required=false)]
            public List<string> LogRegionIds { get; set; }

            [NameInMap("LogStorePattern")]
            [Validation(Required=false)]
            public string LogStorePattern { get; set; }

            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

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
