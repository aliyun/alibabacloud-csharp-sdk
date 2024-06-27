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
            /// <summary>
            /// The current version.
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// The description of the extension.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The extension ID.
            /// </summary>
            [NameInMap("ExtensionId")]
            [Validation(Required=false)]
            public string ExtensionId { get; set; }

            /// <summary>
            /// The names of the databases in which the extension is installed.
            /// </summary>
            [NameInMap("InstalledDatabases")]
            [Validation(Required=false)]
            public string InstalledDatabases { get; set; }

            /// <summary>
            /// Indicates whether an instance restart is required after you install the extension for the extension to take effect.
            /// </summary>
            [NameInMap("IsInstallNeedRestart")]
            [Validation(Required=false)]
            public bool? IsInstallNeedRestart { get; set; }

            /// <summary>
            /// The latest version.
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// The name of the extension.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the extension.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
