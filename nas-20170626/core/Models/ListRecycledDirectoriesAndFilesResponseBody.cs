// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycledDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of information about files or directories in the recycle bin.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListRecycledDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListRecycledDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The last access time. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The last modification time of the metadata. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>The time when the file or directory was deleted. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
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
            /// <para>The last modification time. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

            /// <summary>
            /// <para>The name of the file or directory before it was deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: bytes.</para>
            /// <para>If Type is set to Directory, 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The returned object type. Valid values:</para>
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
        /// <para>The token for the next page.</para>
        /// <para>If the query does not return all files and directories, a non-empty NextToken is returned. You can use the returned NextToken to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
