// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListMiniEngineVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available kernel versions.</para>
        /// </summary>
        [NameInMap("KernelVersions")]
        [Validation(Required=false)]
        public List<ListMiniEngineVersionsResponseBodyKernelVersions> KernelVersions { get; set; }
        public class ListMiniEngineVersionsResponseBodyKernelVersions : TeaModel {
            /// <summary>
            /// <para>The release type of the kernel version. This value is the same as the value returned by the corresponding database product. For example, for ApsaraDB RDS, LTS indicates a long-term support version and BETA indicates a preview version. For PolarDB, the value can be Stable, Old, HighRisk, or Beta.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTS</para>
            /// </summary>
            [NameInMap("KernelReleaseType")]
            [Validation(Required=false)]
            public string KernelReleaseType { get; set; }

            /// <summary>
            /// <para>The available kernel version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_20220731</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>The display name of the kernel version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL 8.0</para>
            /// </summary>
            [NameInMap("KernelVersionName")]
            [Validation(Required=false)]
            public string KernelVersionName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
