// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchesResponseBody : TeaModel {
        /// <summary>
        /// The information about the patch.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The level of the severity.
        /// </summary>
        [NameInMap("Patches")]
        [Validation(Required=false)]
        public List<ListInstancePatchesResponseBodyPatches> Patches { get; set; }
        public class ListInstancePatchesResponseBodyPatches : TeaModel {
            /// <summary>
            /// Queries the patches of an instance.
            /// </summary>
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            /// <summary>
            /// The name of the patch.
            /// </summary>
            [NameInMap("InstalledTime")]
            [Validation(Required=false)]
            public string InstalledTime { get; set; }

            /// <summary>
            /// KBId
            /// </summary>
            [NameInMap("KBId")]
            [Validation(Required=false)]
            public string KBId { get; set; }

            /// <summary>
            /// The status of the installation.
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The time when the patch was installed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The classification of the patch.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
