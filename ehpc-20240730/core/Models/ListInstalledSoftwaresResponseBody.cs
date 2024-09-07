// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListInstalledSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// The list of installed software.
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public ListInstalledSoftwaresResponseBodyAdditionalPackages AdditionalPackages { get; set; }
        public class ListInstalledSoftwaresResponseBodyAdditionalPackages : TeaModel {
            [NameInMap("AdditionalPackageInfos")]
            [Validation(Required=false)]
            public List<ListInstalledSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos> AdditionalPackageInfos { get; set; }
            public class ListInstalledSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos : TeaModel {
                /// <summary>
                /// The category into which the software falls.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The time when the software was installed.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The software description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The URL of the software icon.
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// The software name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The installation status of the software.
                /// 
                /// Valid values:
                /// 
                /// *   Installed
                /// *   Uninstalled
                /// *   Installing
                /// *   Exception
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The software version.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
