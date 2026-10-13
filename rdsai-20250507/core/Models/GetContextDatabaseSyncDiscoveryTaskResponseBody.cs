// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncDiscoveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContextDatabaseSyncDiscoveryTaskResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncDiscoveryTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the cancellation was requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("CancelRequestedAt")]
            [Validation(Required=false)]
            public string CancelRequestedAt { get; set; }

            /// <summary>
            /// <para>The connection ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>The number of containers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000000000</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public long? Containers { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>File size exceeds the limit</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The plug-in reference.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:dingtalk@1.0.0">dingtalk@1.0.0</a></para>
            /// </summary>
            [NameInMap("PluginRef")]
            [Validation(Required=false)]
            public string PluginRef { get; set; }

            /// <summary>
            /// <para>The number of scanned items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000000000</para>
            /// </summary>
            [NameInMap("Scanned")]
            [Validation(Required=false)]
            public long? Scanned { get; set; }

            /// <summary>
            /// <para>The datasource config. The structure varies depending on the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;folderIds&quot;:[&quot;<a href="https://alidocs.dingtalk.com/i/p/p2N9kLmQxYz****%22%5D,%22pageSize%22:50,%22maxDepth%22:5%7D">https://alidocs.dingtalk.com/i/p/p2N9kLmQxYz****&quot;],&quot;pageSize&quot;:50,&quot;maxDepth&quot;:5}</a></para>
            /// </summary>
            [NameInMap("SourceConfig")]
            [Validation(Required=false)]
            public string SourceConfig { get; set; }

            /// <summary>
            /// <para>The data source ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The discovery task status. Valid values: queued, running, succeeded, cancelled, and failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The discovery task ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
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
