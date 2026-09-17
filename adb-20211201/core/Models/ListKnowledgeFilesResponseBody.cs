// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListKnowledgeFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgeFilesResponseBodyData Data { get; set; }
        public class ListKnowledgeFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of file information.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListKnowledgeFilesResponseBodyDataFiles> Files { get; set; }
            public class ListKnowledgeFilesResponseBodyDataFiles : TeaModel {
                /// <summary>
                /// <para>The time when the file was added to the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-09 10:27:35</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>137</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The size of the file, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("FileSizeBytes")]
                [Validation(Required=false)]
                public long? FileSizeBytes { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) URL of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucketName/path/to/file</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>The format of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is a directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDirectory")]
                [Validation(Required=false)]
                public bool? IsDirectory { get; set; }

                /// <summary>
                /// <para>The file_id of the content host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("OwnerFileId")]
                [Validation(Required=false)]
                public long? OwnerFileId { get; set; }

                /// <summary>
                /// <para>The total number of pages in the file, such as the number of pages in a PDF file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PageCount")]
                [Validation(Required=false)]
                public int? PageCount { get; set; }

                /// <summary>
                /// <para>The processing message of the knowledge base file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("ProcessMessage")]
                [Validation(Required=false)]
                public string ProcessMessage { get; set; }

                /// <summary>
                /// <para>The status of the file in the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Processing: The file is being processed.</para>
                /// </description></item>
                /// <item><description><para>Finished: The file has been processed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("ProcessStatus")]
                [Validation(Required=false)]
                public string ProcessStatus { get; set; }

                /// <summary>
                /// <para>The time when the file was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-10 10:23:46</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The message returned by the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The request was successful.</description></item>
            /// <item><description><b>false</b>: The request failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
