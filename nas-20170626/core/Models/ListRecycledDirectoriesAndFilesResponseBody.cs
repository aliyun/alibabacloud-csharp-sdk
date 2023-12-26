// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycledDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// The information about files or directories in the recycle bin.
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecycledDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListRecycledDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// The time when the file or directory was last accessed.
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// The time when the metadata was last modified.
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// The time when the file or directory was deleted.
            /// </summary>
            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            /// <summary>
            /// The IDs of the files or directories.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// The inode of the file or directory.
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// The time when the file or directory was last modified.
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

            /// <summary>
            /// The name of the file or directory before it was deleted.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The size of the file. Unit: bytes.
            /// 
            /// The value 0 is returned for this parameter if Directory is returned for the Type parameter.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The type of the returned object. Valid values:
            /// 
            /// *   File
            /// *   Directory
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// A pagination token.
        /// 
        /// If all the files and directories are incompletely returned in a query, the return value of the NextToken parameter is not empty. In this case, you can specify a valid value for the NextToken parameter to continue the query.
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
