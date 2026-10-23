// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogDownloadLinksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the redo log backups.</para>
        /// </summary>
        [NameInMap("BackupLogDownloadLinkItem")]
        [Validation(Required=false)]
        public List<DescribeBackupLogDownloadLinksResponseBodyBackupLogDownloadLinkItem> BackupLogDownloadLinkItem { get; set; }
        public class DescribeBackupLogDownloadLinksResponseBodyBackupLogDownloadLinkItem : TeaModel {
            /// <summary>
            /// <para>The ID of the redo log backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78167430</para>
            /// </summary>
            [NameInMap("BackupLogId")]
            [Validation(Required=false)]
            public string BackupLogId { get; set; }

            /// <summary>
            /// <para>The public download link for the redo log backup.</para>
            /// </summary>
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            /// <summary>
            /// <para>The error code for the individual record. Empty if the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BackupLogNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The internal network download link for the redo log backup.</para>
            /// </summary>
            [NameInMap("IntranetDownloadLink")]
            [Validation(Required=false)]
            public string IntranetDownloadLink { get; set; }

            /// <summary>
            /// <para>The expiration time of the download link in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-23T03:00:00Z</para>
            /// </summary>
            [NameInMap("LinkExpiredTime")]
            [Validation(Required=false)]
            public string LinkExpiredTime { get; set; }

            /// <summary>
            /// <para>The error message for the individual record. Empty if the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified archived log file does not exist or has been cleaned up.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
