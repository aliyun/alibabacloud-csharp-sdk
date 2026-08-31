// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDataInsightDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The directory information.</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public ListDataInsightDirectoriesResponseBodyDirectory Directory { get; set; }
        public class ListDataInsightDirectoriesResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <para>The directory capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacity")]
            [Validation(Required=false)]
            public long? DirCapacity { get; set; }

            /// <summary>
            /// <para>The capacity of IA files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacityOffline")]
            [Validation(Required=false)]
            public long? DirCapacityOffline { get; set; }

            /// <summary>
            /// <para>The capacity of standard files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacityOnline")]
            [Validation(Required=false)]
            public long? DirCapacityOnline { get; set; }

            /// <summary>
            /// <para>The number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2343232</para>
            /// </summary>
            [NameInMap("FileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <para>The number of Infrequent Access (IA) files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>204800</para>
            /// </summary>
            [NameInMap("FileCountOffline")]
            [Validation(Required=false)]
            public long? FileCountOffline { get; set; }

            /// <summary>
            /// <para>The number of standard files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>204800</para>
            /// </summary>
            [NameInMap("FileCountOnline")]
            [Validation(Required=false)]
            public long? FileCountOnline { get; set; }

            /// <summary>
            /// <para>The inode number of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2343</para>
            /// </summary>
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public long? Inode { get; set; }

            /// <summary>
            /// <para>The subdirectory information.</para>
            /// </summary>
            [NameInMap("SubDirectories")]
            [Validation(Required=false)]
            public List<ListDataInsightDirectoriesResponseBodyDirectorySubDirectories> SubDirectories { get; set; }
            public class ListDataInsightDirectoriesResponseBodyDirectorySubDirectories : TeaModel {
                /// <summary>
                /// <para>The time when the directory was created. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-23T12:47:14Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The capacity of the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>345518080</para>
                /// </summary>
                [NameInMap("DirCapacity")]
                [Validation(Required=false)]
                public long? DirCapacity { get; set; }

                /// <summary>
                /// <para>The capacity of IA files in the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirCapacityOffline")]
                [Validation(Required=false)]
                public long? DirCapacityOffline { get; set; }

                /// <summary>
                /// <para>The capacity of standard files in the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>345518080</para>
                /// </summary>
                [NameInMap("DirCapacityOnline")]
                [Validation(Required=false)]
                public long? DirCapacityOnline { get; set; }

                /// <summary>
                /// <para>The subdirectory level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirLevel")]
                [Validation(Required=false)]
                public int? DirLevel { get; set; }

                /// <summary>
                /// <para>The subdirectory name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dir_l1_n000</para>
                /// </summary>
                [NameInMap("DirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                /// <summary>
                /// <para>The number of files in the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84846</para>
                /// </summary>
                [NameInMap("FileCount")]
                [Validation(Required=false)]
                public long? FileCount { get; set; }

                /// <summary>
                /// <para>The number of IA files in the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2343</para>
                /// </summary>
                [NameInMap("FileCountOffline")]
                [Validation(Required=false)]
                public long? FileCountOffline { get; set; }

                /// <summary>
                /// <para>The number of standard files in the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84355</para>
                /// </summary>
                [NameInMap("FileCountOnline")]
                [Validation(Required=false)]
                public long? FileCountOnline { get; set; }

                /// <summary>
                /// <para>The inode number of the subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140288</para>
                /// </summary>
                [NameInMap("Inode")]
                [Validation(Required=false)]
                public long? Inode { get; set; }

                /// <summary>
                /// <para>The time when the database directory data record was last updated. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-29T03:41:12Z</para>
                /// </summary>
                [NameInMap("LastAccessTime")]
                [Validation(Required=false)]
                public string LastAccessTime { get; set; }

                /// <summary>
                /// <para>The time when the directory was last accessed. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-29T03:41:12Z</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

        }

        /// <summary>
        /// <para>The file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The maximum number of directories returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/subDir</para>
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
