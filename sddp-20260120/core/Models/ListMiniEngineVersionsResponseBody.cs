// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListMiniEngineVersionsResponseBody : TeaModel {
        [NameInMap("KernelVersions")]
        [Validation(Required=false)]
        public List<ListMiniEngineVersionsResponseBodyKernelVersions> KernelVersions { get; set; }
        public class ListMiniEngineVersionsResponseBodyKernelVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>LTS</para>
            /// </summary>
            [NameInMap("KernelReleaseType")]
            [Validation(Required=false)]
            public string KernelReleaseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds_20220731</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL 8.0</para>
            /// </summary>
            [NameInMap("KernelVersionName")]
            [Validation(Required=false)]
            public string KernelVersionName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
