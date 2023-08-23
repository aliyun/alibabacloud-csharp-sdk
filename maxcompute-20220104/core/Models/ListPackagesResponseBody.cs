// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListPackagesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPackagesResponseBodyData Data { get; set; }
        public class ListPackagesResponseBodyData : TeaModel {
            /// <summary>
            /// The packages that were created.
            /// </summary>
            [NameInMap("createdPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataCreatedPackages> CreatedPackages { get; set; }
            public class ListPackagesResponseBodyDataCreatedPackages : TeaModel {
                /// <summary>
                /// The time when the package was created.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The name of the package.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The packages that were installed.
            /// </summary>
            [NameInMap("installedPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataInstalledPackages> InstalledPackages { get; set; }
            public class ListPackagesResponseBodyDataInstalledPackages : TeaModel {
                /// <summary>
                /// The time when the package was installed.
                /// </summary>
                [NameInMap("installTime")]
                [Validation(Required=false)]
                public long? InstallTime { get; set; }

                /// <summary>
                /// The name of the package.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The project to which the package belongs. This parameter is required if the package is installed in the MaxCompute project.
                /// </summary>
                [NameInMap("sourceProject")]
                [Validation(Required=false)]
                public string SourceProject { get; set; }

                /// <summary>
                /// The status of the package.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
