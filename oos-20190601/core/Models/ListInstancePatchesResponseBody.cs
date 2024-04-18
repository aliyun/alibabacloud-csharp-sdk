// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the patch.
        /// </summary>
        [NameInMap("Patches")]
        [Validation(Required=false)]
        public List<ListInstancePatchesResponseBodyPatches> Patches { get; set; }
        public class ListInstancePatchesResponseBodyPatches : TeaModel {
            /// <summary>
            /// The classification of the patch.
            /// </summary>
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            /// <summary>
            /// The time when the patch was installed.
            /// </summary>
            [NameInMap("InstalledTime")]
            [Validation(Required=false)]
            public string InstalledTime { get; set; }

            /// <summary>
            /// The Id of KBId.
            /// </summary>
            [NameInMap("KBId")]
            [Validation(Required=false)]
            public string KBId { get; set; }

            /// <summary>
            /// The level of the severity.
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The status of the installation.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the patch.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
