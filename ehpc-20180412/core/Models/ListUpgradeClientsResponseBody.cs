// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUpgradeClientsResponseBody : TeaModel {
        /// <summary>
        /// The upgrade records of the cluster client.
        /// </summary>
        [NameInMap("ClientRecords")]
        [Validation(Required=false)]
        public List<ListUpgradeClientsResponseBodyClientRecords> ClientRecords { get; set; }
        public class ListUpgradeClientsResponseBodyClientRecords : TeaModel {
            /// <summary>
            /// The version of the E-HPC client after the upgrade.
            /// </summary>
            [NameInMap("NewVersion")]
            [Validation(Required=false)]
            public string NewVersion { get; set; }

            /// <summary>
            /// The version of the E-HPC client before the upgrade.
            /// </summary>
            [NameInMap("OldVersion")]
            [Validation(Required=false)]
            public string OldVersion { get; set; }

            /// <summary>
            /// The ID of the user that upgraded the E-HPC client.
            /// </summary>
            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            /// <summary>
            /// The time when the operation was performed.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The current version of the E-HPC client.
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// The latest version of the E-HPC client.
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
