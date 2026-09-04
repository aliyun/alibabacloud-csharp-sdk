// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RetryDirectoryFailedSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise knowledge base folder. Failed resources in subfolders are recursively included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The number of resources successfully enqueued for retry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("enqueuedCount")]
        [Validation(Required=false)]
        public long? EnqueuedCount { get; set; }

        /// <summary>
        /// <para>The list of source IDs that have been re-enqueued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("enqueuedIds")]
        [Validation(Required=false)]
        public List<string> EnqueuedIds { get; set; }

        /// <summary>
        /// <para>The total number of failed resources in the folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("failedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The list of failed data source IDs.</para>
        /// </summary>
        [NameInMap("failedSources")]
        [Validation(Required=false)]
        public List<RetryDirectoryFailedSourcesResponseBodyFailedSources> FailedSources { get; set; }
        public class RetryDirectoryFailedSourcesResponseBodyFailedSources : TeaModel {
            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSourceId</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of resources skipped because they are not in FAILED status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("skippedCount")]
        [Validation(Required=false)]
        public long? SkippedCount { get; set; }

    }

}
