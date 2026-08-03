// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of directory or file information.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The query time.</para>
            /// <para>The time follows the ISO 8601 standard and is returned in the format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("Atime")]
            [Validation(Required=false)]
            public string Atime { get; set; }

            /// <summary>
            /// <para>The time when the metadata was modified.</para>
            /// <para>The time follows the ISO 8601 standard and is returned in the format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public string Ctime { get; set; }

            /// <summary>
            /// <para>The FileId of the directory or file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains archive storage class files.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains archive storage class files.</description></item>
            /// <item><description>false: The directory does not contain archive storage class files.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public string HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains IA storage class files.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains IA storage class files.</description></item>
            /// <item><description>false: The directory does not contain IA storage class files.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasInfrequentAccessFile")]
            [Validation(Required=false)]
            public bool? HasInfrequentAccessFile { get; set; }

            /// <summary>
            /// <para>The inode of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The time when the file was modified.</para>
            /// <para>The time follows the ISO 8601 standard and is returned in the format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public string Mtime { get; set; }

            /// <summary>
            /// <para>The file name or directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file.txt</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The total duration for which the file has been stored as an archive file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("OfflineDuration")]
            [Validation(Required=false)]
            public long? OfflineDuration { get; set; }

            /// <summary>
            /// <para>The total duration for which the file has remained unchanged since it was stored as an archive file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("OfflineUnchangedDuration")]
            [Validation(Required=false)]
            public long? OfflineUnchangedDuration { get; set; }

            /// <summary>
            /// <para>The portable account ID.
            /// This parameter is meaningful only when ProtocolType is set to SMB and access control is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37862c****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The time when the most recent data retrieval task was run.</para>
            /// <para>The time follows the ISO 8601 standard and is returned in the format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
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
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage class type of the returned file.</para>
            /// <para>This parameter is returned and meaningful only when Type is set to File.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InfrequentAccess: IA storage class.</description></item>
            /// <item><description>Archive: Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The type of the returned result.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>File: file.</description></item>
            /// <item><description>Directory: directory.</description></item>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the return results are truncated, you can use NextToken to initiate a new request to retrieve the content after the current truncation position.</para>
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
