// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetDirectoryOrFilePropertiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the files or directories.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public GetDirectoryOrFilePropertiesResponseBodyEntry Entry { get; set; }
        public class GetDirectoryOrFilePropertiesResponseBodyEntry : TeaModel {
            /// <summary>
            /// <para>The time when the file was queried.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-01T10:08:08Z</para>
            /// </summary>
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }

            /// <summary>
            /// <para>The time when the raw data was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-11T10:08:10Z</para>
            /// </summary>
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains files stored in the Archive storage class.</para>
            /// <para>This parameter is returned only if the Type parameter is set to Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains files stored in the Archive storage class.</description></item>
            /// <item><description>false: The directory does not contain files stored in the Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasArchiveFile")]
            [Validation(Required=false)]
            public bool? HasArchiveFile { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory contains files stored in the IA storage medium.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is Directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The directory contains files stored in the IA storage medium.</description></item>
            /// <item><description>false: The directory does not contain files stored in the IA storage medium.</description></item>
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
            /// <para>40</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }

            /// <summary>
            /// <para>The time when the file was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
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

            /// <summary>
            /// <para>The time when the last data retrieval task was run.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
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
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage type of the file.</para>
            /// <para>This parameter is returned only if the value of the Type parameter is File.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: General-purpose NAS file system</description></item>
            /// <item><description>InfrequentAccess: IA storage medium</description></item>
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
