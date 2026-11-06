// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSourceTemplateRequest : TeaModel {
        [NameInMap("AutoScanNew")]
        [Validation(Required=false)]
        public string AutoScanNew { get; set; }

        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        [NameInMap("DataSourceTemplateId")]
        [Validation(Required=false)]
        public string DataSourceTemplateId { get; set; }

        [NameInMap("DataSourceTemplateName")]
        [Validation(Required=false)]
        public string DataSourceTemplateName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LogProjectPattern")]
        [Validation(Required=false)]
        public string LogProjectPattern { get; set; }

        [NameInMap("LogRegionIds")]
        [Validation(Required=false)]
        public string LogRegionIds { get; set; }

        [NameInMap("LogStorePattern")]
        [Validation(Required=false)]
        public string LogStorePattern { get; set; }

        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public List<string> LogUserIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
