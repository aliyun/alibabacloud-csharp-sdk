// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGraphDraftResourcesResponseBody : TeaModel {
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
        /// <para>The MCP card list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListGraphDraftResourcesResponseBodyItems> Items { get; set; }
        public class ListGraphDraftResourcesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The hash of the draft content itself. The value is a 64-character SHA-256 hexadecimal string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
            /// </summary>
            [NameInMap("baseContentHash")]
            [Validation(Required=false)]
            public string BaseContentHash { get; set; }

            /// <summary>
            /// <para>The active schema version number on which the draft is based.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.0</para>
            /// </summary>
            [NameInMap("baseSchemaVersion")]
            [Validation(Required=false)]
            public string BaseSchemaVersion { get; set; }

            /// <summary>
            /// <para>The unique ID of the draft change. This ID is referenced when you revoke a draft or publish changes.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>401001</para>
            /// </summary>
            [NameInMap("draftChangeId")]
            [Validation(Required=false)]
            public long? DraftChangeId { get; set; }

            /// <summary>
            /// <para>The hash of the online content on which the draft was based when it was saved (draft starting point). The value is a 64-character SHA-256 hexadecimal string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e</para>
            /// </summary>
            [NameInMap("draftContentHash")]
            [Validation(Required=false)]
            public string DraftContentHash { get; set; }

            /// <summary>
            /// <para>The edit mode. In the current implementation, the value is always YAML, which corresponds to sourceType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADVANCED</para>
            /// </summary>
            [NameInMap("editMode")]
            [Validation(Required=false)]
            public string EditMode { get; set; }

            /// <summary>
            /// <para>The actual publish effect relative to the current online state. After a draft is saved, the online graph may have changed, and the operation intent is adjusted based on the current online state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("effectiveOperation")]
            [Validation(Required=false)]
            public string EffectiveOperation { get; set; }

            /// <summary>
            /// <para>The element type. Currently, only text is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>indicator</para>
            /// </summary>
            [NameInMap("elementType")]
            [Validation(Required=false)]
            public string ElementType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T09:00:00+00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T10:30:00+00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the draft baseline has expired. The value is true if the hash of the online content at the time the draft was saved is inconsistent with the hash of the current active content. The ONLINE_CHANGED risk is prompted during publishing.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("hasOnlineChanged")]
            [Validation(Required=false)]
            public bool? HasOnlineChanged { get; set; }

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
            /// <para>The resource name of the agent at runtime.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer_contract_amount</para>
            /// </summary>
            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>element</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The online risk aggregation JSON text (risk_code / risk_message). The value is null if no risk exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;risk_code&quot;: &quot;ONLINE_CHANGED&quot;, &quot;risk_message&quot;: &quot;The online content has changed.&quot;}</para>
            /// </summary>
            [NameInMap("risk")]
            [Validation(Required=false)]
            public string Risk { get; set; }

            /// <summary>
            /// <para>The skill source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YAML</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
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

    }

}
