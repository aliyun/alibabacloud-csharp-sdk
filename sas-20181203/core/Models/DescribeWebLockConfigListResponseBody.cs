// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockConfigListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of web tamper proofing.
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebLockConfigListResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebLockConfigListResponseBodyConfigList : TeaModel {
            /// <summary>
            /// The prevention mode. Valid values:
            /// 
            /// *   **block**: Interception Mode
            /// *   **audit**: Alert Mode
            /// </summary>
            [NameInMap("DefenceMode")]
            [Validation(Required=false)]
            public string DefenceMode { get; set; }

            /// <summary>
            /// The directory that has web tamper proofing enabled.
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// The directory that has web tamper proofing disabled.
            /// 
            /// >  If the value of **Mode** is **blacklist**, this parameter is returned.
            /// </summary>
            [NameInMap("ExclusiveDir")]
            [Validation(Required=false)]
            public string ExclusiveDir { get; set; }

            /// <summary>
            /// The file that has web tamper proofing disabled.
            /// 
            /// >  If the value of **Mode** is **blacklist**, this parameter is returned.
            /// </summary>
            [NameInMap("ExclusiveFile")]
            [Validation(Required=false)]
            public string ExclusiveFile { get; set; }

            /// <summary>
            /// The type of the file that has web tamper proofing disabled.
            /// 
            /// >  If the value of **Mode** is **blacklist**, this parameter is returned.
            /// </summary>
            [NameInMap("ExclusiveFileType")]
            [Validation(Required=false)]
            public string ExclusiveFileType { get; set; }

            /// <summary>
            /// The ID of the directory that has web tamper proofing enabled.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The file that has web tamper proofing enabled.
            /// 
            /// >  If the value of **Mode** is **whitelist**, this parameter is returned.
            /// </summary>
            [NameInMap("InclusiveFile")]
            [Validation(Required=false)]
            public string InclusiveFile { get; set; }

            /// <summary>
            /// The type of the file that has web tamper proofing enabled.
            /// 
            /// >  If the value of **Mode** is **whitelist**, this parameter is returned.
            /// </summary>
            [NameInMap("InclusiveFileType")]
            [Validation(Required=false)]
            public string InclusiveFileType { get; set; }

            /// <summary>
            /// The local path to the backup files of the protected directory.
            /// </summary>
            [NameInMap("LocalBackupDir")]
            [Validation(Required=false)]
            public string LocalBackupDir { get; set; }

            /// <summary>
            /// The protection mode of web tamper proofing. Valid values:
            /// 
            /// *   **whitelist**: In this mode, web tamper proofing is enabled for the specified directories and file types.
            /// *   **blacklist**: In this mode, web tamper proofing is enabled for the unspecified sub-directories, file types, and files in the protected directories.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The UUID of the server that has web tamper proofing enabled.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of directories that have web tamper proofing enabled on the specified server.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
