// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public ListSoftwaresResponseBodyAdditionalPackages AdditionalPackages { get; set; }
        public class ListSoftwaresResponseBodyAdditionalPackages : TeaModel {
            [NameInMap("AdditionalPackageInfos")]
            [Validation(Required=false)]
            public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos> AdditionalPackageInfos { get; set; }
            public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Versions")]
                [Validation(Required=false)]
                public ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersions Versions { get; set; }
                public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersions : TeaModel {
                    [NameInMap("VersionInfos")]
                    [Validation(Required=false)]
                    public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfos> VersionInfos { get; set; }
                    public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfos : TeaModel {
                        [NameInMap("Latest")]
                        [Validation(Required=false)]
                        public string Latest { get; set; }

                        [NameInMap("SupportOs")]
                        [Validation(Required=false)]
                        public ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOs SupportOs { get; set; }
                        public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOs : TeaModel {
                            [NameInMap("SupportOsInfos")]
                            [Validation(Required=false)]
                            public List<ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOsSupportOsInfos> SupportOsInfos { get; set; }
                            public class ListSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfosVersionsVersionInfosSupportOsSupportOsInfos : TeaModel {
                                [NameInMap("Architecture")]
                                [Validation(Required=false)]
                                public string Architecture { get; set; }

                                [NameInMap("OsTag")]
                                [Validation(Required=false)]
                                public string OsTag { get; set; }

                            }

                        }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
