// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPackagesResponseBodyData Data { get; set; }
        public class ListPackagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The packages that were created.</para>
            /// </summary>
            [NameInMap("createdPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataCreatedPackages> CreatedPackages { get; set; }
            public class ListPackagesResponseBodyDataCreatedPackages : TeaModel {
                /// <summary>
                /// <para>The time when the package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02T02:30:34Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>packageA</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The packages that were installed.</para>
            /// </summary>
            [NameInMap("installedPackages")]
            [Validation(Required=false)]
            public List<ListPackagesResponseBodyDataInstalledPackages> InstalledPackages { get; set; }
            public class ListPackagesResponseBodyDataInstalledPackages : TeaModel {
                /// <summary>
                /// <para>The time when the package was installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-02T02:30:34Z</para>
                /// </summary>
                [NameInMap("installTime")]
                [Validation(Required=false)]
                public long? InstallTime { get; set; }

                /// <summary>
                /// <para>The name of the package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>packageB</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project to which the package belongs. This parameter is required if the package is installed in the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectB</para>
                /// </summary>
                [NameInMap("sourceProject")]
                [Validation(Required=false)]
                public string SourceProject { get; set; }

                /// <summary>
                /// <para>The status of the package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3b4aa16677927210252786e4cb6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
