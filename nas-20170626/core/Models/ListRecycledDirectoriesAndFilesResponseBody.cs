// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycledDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecycledDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListRecycledDirectoriesAndFilesResponseBodyEntries : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

    }

}
