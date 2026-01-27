// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the files or directories.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The time when the file was queried.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("Atime")]
            [Validation(Required=false)]
            public string Atime { get; set; }

            /// <summary>
            /// <para>The time when the raw data was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public string Ctime { get; set; }

            /// <summary>
            /// <para>The ID of the directory or file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains files stored in the Archive storage class.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains files stored in the Archive storage class.</description></item>
            /// <item><description>false: The directory does not contain files stored in the Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public string HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains files stored in the IA storage class.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains files stored in the IA storage class.</description></item>
            /// <item><description>false: The directory does not contain files stored in the IA storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasInfrequentAccessFile")]
            [Validation(Required=false)]
            public bool? HasInfrequentAccessFile { get; set; }

            /// <summary>
            /// <para>The file or directory inode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The time when the file was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public string Mtime { get; set; }

            /// <summary>
            /// <para>The name of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file.txt</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OfflineDuration")]
            [Validation(Required=false)]
            public long? OfflineDuration { get; set; }

            [NameInMap("OfflineUnchangedDuration")]
            [Validation(Required=false)]
            public long? OfflineUnchangedDuration { get; set; }

            /// <summary>
            /// <para>The ID of the portable account. This parameter is returned and valid only if the value of the ProtocolType parameter is SMB and RAM-based access control is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37862c****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The time when the last data retrieval task was run.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }

            /// <summary>
            /// <para>The size of the file.</para>
            /// <para>Unit: bytes.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage class.</para>
            /// <para>This parameter is returned and valid only if the value of the Type parameter is File.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InfrequentAccess: the IA storage class.</description></item>
            /// <item><description>Archive: the Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The type of the query result.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>File</description></item>
            /// <item><description>Directory</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Directory</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
