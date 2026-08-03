// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycledDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about files or directories in the recycle bin.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecycledDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListRecycledDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The most recent access time. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The most recent metadata modification time. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>The time when the file or directory was deleted. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            /// <summary>
            /// <para>The FileId of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04***08</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The inode of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04***08</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The most recent modification time. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

            /// <summary>
            /// <para>The name of the file or directory before deletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// <para>If Type is set to Directory, the value 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>File: file</description></item>
            /// <item><description>Directory: folder</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>File</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// <para>If a single query does not return all files and directories, a non-empty NextToken is returned. You can specify the correct NextToken in subsequent queries to continue listing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
