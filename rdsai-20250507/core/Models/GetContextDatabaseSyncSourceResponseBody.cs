// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncSourceResponseBody : TeaModel {
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
        public GetContextDatabaseSyncSourceResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The confirmation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("ConfirmedAt")]
            [Validation(Required=false)]
            public string ConfirmedAt { get; set; }

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
            /// <para>The data source ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D team document scope</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of selected node keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;doc:1234567890&quot;]</para>
            /// </summary>
            [NameInMap("SelectedNodeKeys")]
            [Validation(Required=false)]
            public List<string> SelectedNodeKeys { get; set; }

            /// <summary>
            /// <para>The selection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subtree</para>
            /// </summary>
            [NameInMap("SelectionPolicy")]
            [Validation(Required=false)]
            public string SelectionPolicy { get; set; }

            /// <summary>
            /// <para>The datasource config, which varies by plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;folderIds&quot;:[&quot;<a href="https://alidocs.dingtalk.com/i/p/p2N9kLmQxYz****%22%5D,%22pageSize%22:50,%22maxDepth%22:5%7D">https://alidocs.dingtalk.com/i/p/p2N9kLmQxYz****&quot;],&quot;pageSize&quot;:50,&quot;maxDepth&quot;:5}</a></para>
            /// </summary>
            [NameInMap("SourceConfig")]
            [Validation(Required=false)]
            public string SourceConfig { get; set; }

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
        /// <para>The message.</para>
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
