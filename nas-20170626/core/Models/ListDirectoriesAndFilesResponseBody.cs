// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// The details about the files or directories.
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// The time when the file was queried.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("Atime")]
            [Validation(Required=false)]
            public string Atime { get; set; }

            /// <summary>
            /// The time when the raw data was modified.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public string Ctime { get; set; }

            /// <summary>
            /// The ID of the directory or file.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// Indicates whether the directory contains files stored in the Archive storage class.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is Directory.
            /// 
            /// Valid values:
            /// 
            /// *   true: The directory contains files stored in the Archive storage class.
            /// *   false: The directory does not contain files stored in the Archive storage class.
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public string HasArchiveFile { get; set; }

            /// <summary>
            /// Indicates whether the directory contains files stored in the IA storage class.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is Directory.
            /// 
            /// Valid values:
            /// 
            /// *   true: The directory contains files stored in the IA storage class.
            /// *   false: The directory does not contain files stored in the IA storage class.
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
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public string Mtime { get; set; }

            /// <summary>
            /// The name of the file or directory.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the portable account. This parameter is returned and valid only if the value of the ProtocolType parameter is SMB and RAM-based access control is enabled.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The time when the last data retrieval task was run.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }

            /// <summary>
            /// The size of the file.
            /// 
            /// Unit: bytes.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The storage class.
            /// 
            /// This parameter is returned and valid only if the value of the Type parameter is File.
            /// 
            /// Valid values:
            /// 
            /// *   InfrequentAccess: the IA storage class.
            /// *   Archive: the Archive storage class.
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
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
