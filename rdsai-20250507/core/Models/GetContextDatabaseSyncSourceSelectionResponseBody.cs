// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncSourceSelectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContextDatabaseSyncSourceSelectionResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncSourceSelectionResponseBodyData : TeaModel {
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
            /// <para>The list of selected node identifiers.</para>
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
            /// <para>The update time.</para>
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
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
