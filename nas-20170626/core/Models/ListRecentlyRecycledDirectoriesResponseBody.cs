// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecentlyRecycledDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// The information about the directories that are recently deleted.
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecentlyRecycledDirectoriesResponseBodyEntries> Entries { get; set; }
        public class ListRecentlyRecycledDirectoriesResponseBodyEntries : TeaModel {
            /// <summary>
            /// The ID of the directory.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// The time when the directory was last deleted.
            /// </summary>
            [NameInMap("LastDeleteTime")]
            [Validation(Required=false)]
            public string LastDeleteTime { get; set; }

            /// <summary>
            /// The name of the directory.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The absolute path to the directory.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// A pagination token.
        /// 
        /// If not all directories are returned in a query, the return value of the NextToken parameter is not empty. In this case, you can specify a valid value for the NextToken parameter to continue the query.
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
