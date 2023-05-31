// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupRestoreCountResponseBody : TeaModel {
        /// <summary>
        /// The statistics of restoration tasks.
        /// </summary>
        [NameInMap("BackupRestoreCount")]
        [Validation(Required=false)]
        public DescribeBackupRestoreCountResponseBodyBackupRestoreCount BackupRestoreCount { get; set; }
        public class DescribeBackupRestoreCountResponseBodyBackupRestoreCount : TeaModel {
            /// <summary>
            /// The number of the restoration tasks that are in the **being restored** state.
            /// </summary>
            [NameInMap("Recovering")]
            [Validation(Required=false)]
            public int? Recovering { get; set; }

            /// <summary>
            /// The total number of the restoration tasks that you create.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
