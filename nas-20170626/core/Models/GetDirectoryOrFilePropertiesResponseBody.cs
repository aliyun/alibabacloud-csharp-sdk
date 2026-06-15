// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetDirectoryOrFilePropertiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The properties of the directory or file.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public GetDirectoryOrFilePropertiesResponseBodyEntry Entry { get; set; }
        public class GetDirectoryOrFilePropertiesResponseBodyEntry : TeaModel {
            /// <summary>
            /// <para>The time when the file was last accessed.</para>
            /// <para>The time is displayed in the ISO 8601 standard format and is returned in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</para>
            /// <para>This parameter is returned only if Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The time when the metadata of the file was last modified.</para>
            /// <para>The time is displayed in the ISO 8601 standard format and is returned in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</para>
            /// <para>This parameter is returned only if Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains an archive file.</para>
            /// <para>This parameter is returned only if Type is set to Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The directory contains at least one archive file.</para>
            /// </description></item>
            /// <item><description><para>false: The directory does not contain archive files.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public bool? HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains an Infrequent Access (IA) file.</para>
            /// <para>This parameter is returned only if Type is set to Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The directory contains at least one IA file.</para>
            /// </description></item>
            /// <item><description><para>false: The directory does not contain IA files.</para>
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
            /// <para>40</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The time when the file was last modified.</para>
            /// <para>The time is displayed in the ISO 8601 standard format and is returned in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</para>
            /// <para>This parameter is returned only if Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

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
            /// <para>The time when the last data retrieval task was run.</para>
            /// <para>The time is displayed in the ISO 8601 standard format and is returned in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</para>
            /// <para>This parameter is returned only if Type is set to File.</para>
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
            /// <para>This parameter is returned only if Type is set to File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage type of the file.</para>
            /// <para>This parameter is returned only if Type is set to File.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Standard: General-purpose NAS file systems</para>
            /// </description></item>
            /// <item><description><para>InfrequentAccess: IA storage medium</para>
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
            /// <para>The type of the returned entry.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>File: The entry is a file.</para>
            /// </description></item>
            /// <item><description><para>Directory: The entry is a directory.</para>
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
