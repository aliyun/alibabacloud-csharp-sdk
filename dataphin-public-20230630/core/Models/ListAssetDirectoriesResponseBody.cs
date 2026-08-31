// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAssetDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paginated result of asset topic folders.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAssetDirectoriesResponseBodyData Data { get; set; }
        public class ListAssetDirectoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The folder list.</para>
            /// </summary>
            [NameInMap("DirectoryList")]
            [Validation(Required=false)]
            public List<ListAssetDirectoriesResponseBodyDataDirectoryList> DirectoryList { get; set; }
            public class ListAssetDirectoriesResponseBodyDataDirectoryList : TeaModel {
                /// <summary>
                /// <para>The folder description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core metrics asset folder</para>
                /// </summary>
                [NameInMap("DirectoryDescription")]
                [Validation(Required=false)]
                public string DirectoryDescription { get; set; }

                /// <summary>
                /// <para>The folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8223183275</para>
                /// </summary>
                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public long? DirectoryId { get; set; }

                /// <summary>
                /// <para>The folder name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core Metrics</para>
                /// </summary>
                [NameInMap("DirectoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

                /// <summary>
                /// <para>The display path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/Data Governance/Core Metrics</para>
                /// </summary>
                [NameInMap("FullPath")]
                [Validation(Required=false)]
                public string FullPath { get; set; }

                /// <summary>
                /// <para>The ID path from the top level to the current folder.</para>
                /// </summary>
                [NameInMap("FullPathIds")]
                [Validation(Required=false)]
                public List<long?> FullPathIds { get; set; }

                /// <summary>
                /// <para>The name path from the top level to the current folder.</para>
                /// </summary>
                [NameInMap("FullPathNames")]
                [Validation(Required=false)]
                public List<string> FullPathNames { get; set; }

                /// <summary>
                /// <para>Indicates whether published direct child folders exist.</para>
                /// </summary>
                [NameInMap("HasChildren")]
                [Validation(Required=false)]
                public bool? HasChildren { get; set; }

                /// <summary>
                /// <para>The absolute level of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7120213</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <para>The last modifier.</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public ListAssetDirectoriesResponseBodyDataDirectoryListModifier Modifier { get; set; }
                public class ListAssetDirectoriesResponseBodyDataDirectoryListModifier : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30001011</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The parent folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-292276281678</para>
                /// </summary>
                [NameInMap("ParentDirectoryId")]
                [Validation(Required=false)]
                public long? ParentDirectoryId { get; set; }

            }

            /// <summary>
            /// <para>The topic ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>471794724245</para>
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Governance</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The total number of records that match the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-165955346599</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
