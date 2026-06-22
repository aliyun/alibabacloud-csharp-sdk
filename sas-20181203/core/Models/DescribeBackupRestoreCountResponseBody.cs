// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupRestoreCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of anti-ransomware restoration tasks.</para>
        /// </summary>
        [NameInMap("BackupRestoreCount")]
        [Validation(Required=false)]
        public DescribeBackupRestoreCountResponseBodyBackupRestoreCount BackupRestoreCount { get; set; }
        public class DescribeBackupRestoreCountResponseBodyBackupRestoreCount : TeaModel {
            /// <summary>
            /// <para>The number of tasks in the <b>Restoring</b> state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Recovering")]
            [Validation(Required=false)]
            public int? Recovering { get; set; }

            /// <summary>
            /// <para>The total number of restoration tasks that have been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC6B3E3-D496-512D-B46D-E6996A6B63EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
