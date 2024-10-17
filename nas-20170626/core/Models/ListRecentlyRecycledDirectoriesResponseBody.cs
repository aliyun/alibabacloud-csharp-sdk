// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecentlyRecycledDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the directories that are recently deleted.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecentlyRecycledDirectoriesResponseBodyEntries> Entries { get; set; }
        public class ListRecentlyRecycledDirectoriesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04***08</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The time when the directory was last deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("LastDeleteTime")]
            [Validation(Required=false)]
            public string LastDeleteTime { get; set; }

            /// <summary>
            /// <para>The name of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The absolute path to the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/b</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>A pagination token.</para>
        /// <para>If not all directories are returned in a query, the return value of the NextToken parameter is not empty. In this case, you can specify a valid value for the NextToken parameter to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1256****25</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E15E394-38A6-457A-A62A-D9797C9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
