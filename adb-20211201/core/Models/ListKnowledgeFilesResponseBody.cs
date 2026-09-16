// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListKnowledgeFilesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgeFilesResponseBodyData Data { get; set; }
        public class ListKnowledgeFilesResponseBodyData : TeaModel {
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListKnowledgeFilesResponseBodyDataFiles> Files { get; set; }
            public class ListKnowledgeFilesResponseBodyDataFiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-06-09 10:27:35</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>137</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("FileSizeBytes")]
                [Validation(Required=false)]
                public long? FileSizeBytes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucketName/path/to/file</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDirectory")]
                [Validation(Required=false)]
                public bool? IsDirectory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("OwnerFileId")]
                [Validation(Required=false)]
                public long? OwnerFileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PageCount")]
                [Validation(Required=false)]
                public int? PageCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("ProcessMessage")]
                [Validation(Required=false)]
                public string ProcessMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("ProcessStatus")]
                [Validation(Required=false)]
                public string ProcessStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-06-10 10:23:46</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
