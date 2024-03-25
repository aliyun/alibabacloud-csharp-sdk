// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetDirectoryOrFilePropertiesResponseBody : TeaModel {
        /// <summary>
        /// The details about the file or directory.
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public GetDirectoryOrFilePropertiesResponseBodyEntry Entry { get; set; }
        public class GetDirectoryOrFilePropertiesResponseBodyEntry : TeaModel {
            /// <summary>
            /// The time when the file was queried.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// The time when the raw data was modified.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public bool? HasArchiveFile { get; set; }

            /// <summary>
            /// Indicates whether the directory contains files stored in the IA storage medium.
            /// 
            /// This parameter is returned only if the value of the Type parameter is Directory.
            /// 
            /// Valid values:
            /// 
            /// *   true: The directory contains files stored in the IA storage medium.
            /// *   false: The directory does not contain files stored in the IA storage medium.
            /// </summary>
            [NameInMap("HasInfrequentAccessFile")]
            [Validation(Required=false)]
            public bool? HasInfrequentAccessFile { get; set; }

            /// <summary>
            /// The file or directory inode.
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// The time when the file was modified.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

            /// <summary>
            /// The name of the file or directory.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The time when the last data retrieval task was run.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }

            /// <summary>
            /// The size of the file.
            /// 
            /// Unit: bytes.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The storage type of the file.
            /// 
            /// This parameter is returned only if the value of the Type parameter is File.
            /// 
            /// Valid values:
            /// 
            /// *   standard: General-purpose NAS file system
            /// *   InfrequentAccess: IA storage medium
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// The type of the query result.
            /// 
            /// Valid values:
            /// 
            /// *   File
            /// *   Directory
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
