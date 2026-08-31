// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetDirectoryOrFilePropertiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The directory or file information.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public GetDirectoryOrFilePropertiesResponseBodyEntry Entry { get; set; }
        public class GetDirectoryOrFilePropertiesResponseBodyEntry : TeaModel {
            /// <summary>
            /// <para>The time when the file was queried.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only when Type is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The time when the metadata was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only when Type is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains Archive storage class files.</para>
            /// <para>This parameter is returned only when Type is Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains Archive storage class files.</description></item>
            /// <item><description>false: The directory does not contain Archive storage class files.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public bool? HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains IA storage class files.</para>
            /// <para>This parameter is returned only when Type is Directory.</para>
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
            /// <para>40</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The time when the file was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only when Type is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:08Z</para>
            /// </summary>
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }

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
            /// <para>The total duration for which the file has been stored as an Archive file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("OfflineDuration")]
            [Validation(Required=false)]
            public long? OfflineDuration { get; set; }

            /// <summary>
            /// <para>The total duration for which the file has remained unchanged since it was stored as an Archive file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("OfflineUnchangedDuration")]
            [Validation(Required=false)]
            public long? OfflineUnchangedDuration { get; set; }

            /// <summary>
            /// <para>The time when the most recent data retrieval task was executed.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only when Type is File.</para>
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
            /// <para>This parameter is returned only when Type is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage type of the returned file.</para>
            /// <para>This parameter is returned only when Type is File.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: General-purpose NAS storage.</description></item>
            /// <item><description>InfrequentAccess: IA storage class.</description></item>
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
            /// <item><description>File: file</description></item>
            /// <item><description>Directory: directory</description></item>
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
