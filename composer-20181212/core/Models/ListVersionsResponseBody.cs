// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListVersionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of versions of the workflow.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// A list of the versions.
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListVersionsResponseBodyVersions> Versions { get; set; }
        public class ListVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// The time when the version was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the workflow to which the version belongs.
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// The time when the version was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// The name of the version.
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// The number of the version. Increment from 1.
            /// </summary>
            [NameInMap("VersionNumber")]
            [Validation(Required=false)]
            public int? VersionNumber { get; set; }

            /// <summary>
            /// The status of the version. **Enabled** indicates that the version is enabled.
            /// </summary>
            [NameInMap("VersionStatus")]
            [Validation(Required=false)]
            public string VersionStatus { get; set; }

        }

    }

}
