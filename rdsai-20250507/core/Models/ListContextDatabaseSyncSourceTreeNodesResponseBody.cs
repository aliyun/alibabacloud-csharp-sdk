// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncSourceTreeNodesResponseBody : TeaModel {
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
        public List<ListContextDatabaseSyncSourceTreeNodesResponseBodyData> Data { get; set; }
        public class ListContextDatabaseSyncSourceTreeNodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The discovery time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("DiscoveredAt")]
            [Validation(Required=false)]
            public string DiscoveredAt { get; set; }

            /// <summary>
            /// <para>The file name extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.docx</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>Indicates whether the node has child nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>folder</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The node identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc:1234567890</para>
            /// </summary>
            [NameInMap("NodeKey")]
            [Validation(Required=false)]
            public string NodeKey { get; set; }

            /// <summary>
            /// <para>The parent node identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>folder:9876543210</para>
            /// </summary>
            [NameInMap("ParentKey")]
            [Validation(Required=false)]
            public string ParentKey { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("StaleAt")]
            [Validation(Required=false)]
            public string StaleAt { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Project plan</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The reason why the operation is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The current plugin does not support this operation</para>
            /// </summary>
            [NameInMap("UnsupportedReason")]
            [Validation(Required=false)]
            public string UnsupportedReason { get; set; }

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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
