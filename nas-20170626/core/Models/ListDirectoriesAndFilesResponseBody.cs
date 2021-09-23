// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListDirectoriesAndFilesResponseBodyEntries : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("HasInfrequentAccessFile")]
            [Validation(Required=false)]
            public bool? HasInfrequentAccessFile { get; set; }

            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public string Ctime { get; set; }

            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public string Mtime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("Atime")]
            [Validation(Required=false)]
            public string Atime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }

            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

    }

}
