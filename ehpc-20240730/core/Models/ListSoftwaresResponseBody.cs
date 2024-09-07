// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// The information about the software that can be installed in the cluster.
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public ListSoftwaresResponseBodyAdditionalPackages AdditionalPackages { get; set; }
        public class ListSoftwaresResponseBodyAdditionalPackages : TeaModel {
            [NameInMap("AdditionalPackageInfos")]
            [Validation(Required=false)]
            public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos> AdditionalPackageInfos { get; set; }
            public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos : TeaModel {
                /// <summary>
                /// The application category.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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
                /// The information about the software versions that can be installed in the cluster.
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersions Versions { get; set; }
                public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersions : TeaModel {
                    [NameInMap("VersionInfos")]
                    [Validation(Required=false)]
                    public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfos> VersionInfos { get; set; }
                    public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfos : TeaModel {
                        /// <summary>
                        /// Indicates whether the version is the latest.
                        /// </summary>
                        [NameInMap("Latest")]
                        [Validation(Required=false)]
                        public string Latest { get; set; }

                        /// <summary>
                        /// The information about the supported OSs.
                        /// </summary>
                        [NameInMap("SupportOs")]
                        [Validation(Required=false)]
                        public ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOs SupportOs { get; set; }
                        public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOs : TeaModel {
                            [NameInMap("SupportOsInfos")]
                            [Validation(Required=false)]
                            public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOsSupportOsInfos> SupportOsInfos { get; set; }
                            public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOsSupportOsInfos : TeaModel {
                                /// <summary>
                                /// The OS architecture. Valid values:
                                /// 
                                /// *   x86_64
                                /// *   arm64
                                /// </summary>
                                [NameInMap("Architecture")]
                                [Validation(Required=false)]
                                public string Architecture { get; set; }

                                /// <summary>
                                /// The image tag.
                                /// </summary>
                                [NameInMap("OsTag")]
                                [Validation(Required=false)]
                                public string OsTag { get; set; }

                            }

                        }

                        /// <summary>
                        /// The software version.
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
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
