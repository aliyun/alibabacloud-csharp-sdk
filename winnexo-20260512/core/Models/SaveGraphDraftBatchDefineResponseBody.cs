// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveGraphDraftBatchDefineResponseBody : TeaModel {
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
        /// <para>The graph name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The list of MCP cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SaveGraphDraftBatchDefineResponseBodyItems> Items { get; set; }
        public class SaveGraphDraftBatchDefineResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The hash of the draft content itself, a 64-character SHA-256 hexadecimal string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e</para>
            /// </summary>
            [NameInMap("baseContentHash")]
            [Validation(Required=false)]
            public string BaseContentHash { get; set; }

            /// <summary>
            /// <para>The active schema version number on which the draft is based.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.3</para>
            /// </summary>
            [NameInMap("baseSchemaVersion")]
            [Validation(Required=false)]
            public string BaseSchemaVersion { get; set; }

            /// <summary>
            /// <para>The unique draft change ID, referenced when revoking drafts or publishing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>401001</para>
            /// </summary>
            [NameInMap("draftChangeId")]
            [Validation(Required=false)]
            public long? DraftChangeId { get; set; }

            /// <summary>
            /// <para>The online content hash on which the draft save is based (draft starting point), a 64-character SHA-256 hexadecimal string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
            /// </summary>
            [NameInMap("draftContentHash")]
            [Validation(Required=false)]
            public string DraftContentHash { get; set; }

            /// <summary>
            /// <para>The element type. Currently, only text is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>object_type</para>
            /// </summary>
            [NameInMap("elementType")]
            [Validation(Required=false)]
            public string ElementType { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-11T10:30:00+00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("operationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The resource name of the agent runtime.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>object</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BATCH_DEFINE</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
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
        /// <para>The save mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL_YAML</para>
        /// </summary>
        [NameInMap("saveMode")]
        [Validation(Required=false)]
        public string SaveMode { get; set; }

        /// <summary>
        /// <para>The number of saved items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("savedCount")]
        [Validation(Required=false)]
        public int? SavedCount { get; set; }

    }

}
