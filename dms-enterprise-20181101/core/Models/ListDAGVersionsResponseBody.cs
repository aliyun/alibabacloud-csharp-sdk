// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDAGVersionsResponseBody : TeaModel {
        /// <summary>
        /// The information about the published versions.
        /// </summary>
        [NameInMap("DagVersionList")]
        [Validation(Required=false)]
        public ListDAGVersionsResponseBodyDagVersionList DagVersionList { get; set; }
        public class ListDAGVersionsResponseBodyDagVersionList : TeaModel {
            [NameInMap("DagVersion")]
            [Validation(Required=false)]
            public List<ListDAGVersionsResponseBodyDagVersionListDagVersion> DagVersion { get; set; }
            public class ListDAGVersionsResponseBodyDagVersionListDagVersion : TeaModel {
                /// <summary>
                /// The name of the task flow.
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// The ID of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// The name of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The ID of the previously published version.
                /// </summary>
                [NameInMap("LastVersionId")]
                [Validation(Required=false)]
                public long? LastVersionId { get; set; }

                /// <summary>
                /// The description of the version.
                /// </summary>
                [NameInMap("VersionComments")]
                [Validation(Required=false)]
                public string VersionComments { get; set; }

                /// <summary>
                /// The ID of the version.
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public long? VersionId { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
