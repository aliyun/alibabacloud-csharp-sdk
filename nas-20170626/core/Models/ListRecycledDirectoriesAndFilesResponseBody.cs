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
            /// <para>The time when the file or directory was last accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The time when the metadata was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>The time when the file or directory was deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            /// <summary>
            /// <para>The IDs of the files or directories.</para>
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
            /// <para>The time when the file or directory was last modified.</para>
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
            /// <para>The value 0 is returned for this parameter if Directory is returned for the Type parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The type of the returned object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>File</description></item>
            /// <item><description>Directory</description></item>
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
        /// <para>A pagination token.</para>
        /// <para>If all the files and directories are incompletely returned in a query, the return value of the NextToken parameter is not empty. In this case, you can specify a valid value for the NextToken parameter to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CKuO8QMSIjE2OTc3NzI0NjI5MTcyMTYyNDVfMzEzNTUyMF81MjEzODY=</para>
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
