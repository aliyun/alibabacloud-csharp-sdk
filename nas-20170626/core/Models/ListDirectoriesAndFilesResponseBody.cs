// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of directory and file entries.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<ListDirectoriesAndFilesResponseBodyEntries> Entries { get; set; }
        public class ListDirectoriesAndFilesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The last access time (atime) of the file.</para>
            /// <para>The time is in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("Atime")]
            [Validation(Required=false)]
            public string Atime { get; set; }

            /// <summary>
            /// <para>The metadata change time (ctime) of the file.</para>
            /// <para>The time is in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public string Ctime { get; set; }

            /// <summary>
            /// <para>The ID of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>Specifies whether the directory contains any archive files.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>Directory</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public string HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Specifies whether the directory contains any infrequent access files.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>Directory</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No</para>
            /// </description></item>
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
            /// <para>The last modification time (mtime) of the file.</para>
            /// <para>The time is in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
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
            /// <para>The owner of the file or directory. This parameter is returned only when <c>ProtocolType</c> is <c>SMB</c> and access control is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37862c****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The last data retrieval time.</para>
            /// <para>The time is in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }

            /// <summary>
            /// <para>The size of the file, in bytes.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
            /// <para>This value is returned and is meaningful only when Type is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage class of the file.</para>
            /// <para>This parameter is returned only when <c>Type</c> is <c>File</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>InfrequentAccess</c></para>
            /// </description></item>
            /// <item><description><para><c>Archive</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The type of the entry.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>File</c>: a file</para>
            /// </description></item>
            /// <item><description><para><c>Directory</c>: a directory</para>
            /// </description></item>
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
        /// <para>The pagination token. If the response is truncated, include this token in the next request to retrieve the next page of results.</para>
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
