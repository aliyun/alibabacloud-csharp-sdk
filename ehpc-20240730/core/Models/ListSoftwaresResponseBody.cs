// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the software that can be installed in the cluster.</para>
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
                /// <para>The application category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NWP</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The software description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the software icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i2/O1CN01FIkxZ81LmE0fvrAyR_!!6000000001341-55-tps-6349-1603.svg">https://gw.alicdn.com/imgextra/i2/O1CN01FIkxZ81LmE0fvrAyR_!!6000000001341-55-tps-6349-1603.svg</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gromacs</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The information about the software versions that can be installed in the cluster.</para>
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
                        /// <para>Indicates whether the version is the latest.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Latest")]
                        [Validation(Required=false)]
                        public string Latest { get; set; }

                        /// <summary>
                        /// <para>The information about the supported OSs.</para>
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
                                /// <para>The OS architecture. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>x86_64</description></item>
                                /// <item><description>arm64</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>x86_64</para>
                                /// </summary>
                                [NameInMap("Architecture")]
                                [Validation(Required=false)]
                                public string Architecture { get; set; }

                                /// <summary>
                                /// <para>The image tag.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Alibaba Cloud Linux  3.2104 LTS 64 bit ARM Edition</para>
                                /// </summary>
                                [NameInMap("OsTag")]
                                [Validation(Required=false)]
                                public string OsTag { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The software version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024.1</para>
                        /// </summary>
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
