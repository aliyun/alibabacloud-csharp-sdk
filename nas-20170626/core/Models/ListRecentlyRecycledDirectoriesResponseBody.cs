// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecentlyRecycledDirectoriesResponseBody : TeaModel {
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
        public List<ListRecentlyRecycledDirectoriesResponseBodyEntries> Entries { get; set; }
        public class ListRecentlyRecycledDirectoriesResponseBodyEntries : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("LastDeleteTime")]
            [Validation(Required=false)]
            public string LastDeleteTime { get; set; }

        }

    }

}
