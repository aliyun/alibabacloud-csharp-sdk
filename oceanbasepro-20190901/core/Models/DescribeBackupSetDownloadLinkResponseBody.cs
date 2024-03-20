// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeBackupSetDownloadLinkResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadLinkResponseBodyData Data { get; set; }
        public class DescribeBackupSetDownloadLinkResponseBodyData : TeaModel {
            /// <summary>
            /// The restorable time of the backup set.
            /// </summary>
            [NameInMap("BackupRestorableTime")]
            [Validation(Required=false)]
            public string BackupRestorableTime { get; set; }

            /// <summary>
            /// The ID of the target backup set.
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            /// <summary>
            /// The time when the download task corresponding to the target backup set was created.
            /// </summary>
            [NameInMap("DownloadTaskCreateTime")]
            [Validation(Required=false)]
            public string DownloadTaskCreateTime { get; set; }

            /// <summary>
            /// The ID of the download task corresponding to the target backup set.
            /// </summary>
            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public long? DownloadTaskId { get; set; }

            /// <summary>
            /// The status of the download task corresponding to the target backup set.
            /// </summary>
            [NameInMap("DownloadTaskStatus")]
            [Validation(Required=false)]
            public string DownloadTaskStatus { get; set; }

            /// <summary>
            /// The internal URL.
            /// </summary>
            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            /// <summary>
            /// The validity period of the URL, in seconds.
            /// </summary>
            [NameInMap("UrlAliveTime")]
            [Validation(Required=false)]
            public long? UrlAliveTime { get; set; }

            /// <summary>
            /// The expiration time of the URL.
            /// </summary>
            [NameInMap("UrlExpiredTime")]
            [Validation(Required=false)]
            public string UrlExpiredTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
