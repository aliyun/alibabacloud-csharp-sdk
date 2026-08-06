// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDataInsightDirectoriesResponseBody : TeaModel {
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public ListDataInsightDirectoriesResponseBodyDirectory Directory { get; set; }
        public class ListDataInsightDirectoriesResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacity")]
            [Validation(Required=false)]
            public long? DirCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacityOffline")]
            [Validation(Required=false)]
            public long? DirCapacityOffline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DirCapacityOnline")]
            [Validation(Required=false)]
            public long? DirCapacityOnline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2343232</para>
            /// </summary>
            [NameInMap("FileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>204800</para>
            /// </summary>
            [NameInMap("FileCountOffline")]
            [Validation(Required=false)]
            public long? FileCountOffline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>204800</para>
            /// </summary>
            [NameInMap("FileCountOnline")]
            [Validation(Required=false)]
            public long? FileCountOnline { get; set; }

            [NameInMap("SubDirectories")]
            [Validation(Required=false)]
            public List<ListDataInsightDirectoriesResponseBodyDirectorySubDirectories> SubDirectories { get; set; }
            public class ListDataInsightDirectoriesResponseBodyDirectorySubDirectories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-23T12:47:14Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>345518080</para>
                /// </summary>
                [NameInMap("DirCapacity")]
                [Validation(Required=false)]
                public long? DirCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirCapacityOffline")]
                [Validation(Required=false)]
                public long? DirCapacityOffline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>345518080</para>
                /// </summary>
                [NameInMap("DirCapacityOnline")]
                [Validation(Required=false)]
                public long? DirCapacityOnline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirLevel")]
                [Validation(Required=false)]
                public int? DirLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/dir_l1_n000</para>
                /// </summary>
                [NameInMap("DirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>84846</para>
                /// </summary>
                [NameInMap("FileCount")]
                [Validation(Required=false)]
                public long? FileCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2343</para>
                /// </summary>
                [NameInMap("FileCountOffline")]
                [Validation(Required=false)]
                public long? FileCountOffline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>84355</para>
                /// </summary>
                [NameInMap("FileCountOnline")]
                [Validation(Required=false)]
                public long? FileCountOnline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-29T03:41:12Z</para>
                /// </summary>
                [NameInMap("LastAccessTime")]
                [Validation(Required=false)]
                public string LastAccessTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-29T03:41:12Z</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/subDir</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
