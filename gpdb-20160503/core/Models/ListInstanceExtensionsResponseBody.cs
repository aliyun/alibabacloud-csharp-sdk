// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListInstanceExtensionsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListInstanceExtensionsResponseBodyItems> Items { get; set; }
        public class ListInstanceExtensionsResponseBodyItems : TeaModel {
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtensionId")]
            [Validation(Required=false)]
            public string ExtensionId { get; set; }

            [NameInMap("InstalledDatabases")]
            [Validation(Required=false)]
            public string InstalledDatabases { get; set; }

            [NameInMap("IsInstallNeedRestart")]
            [Validation(Required=false)]
            public bool? IsInstallNeedRestart { get; set; }

            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
