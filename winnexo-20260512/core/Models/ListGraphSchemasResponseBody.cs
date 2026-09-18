// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGraphSchemasResponseBody : TeaModel {
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
        /// <para>The location clustering.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListGraphSchemasResponseBodyItems> Items { get; set; }
        public class ListGraphSchemasResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The currently active schema version number. The value is 0.0.0 for a quick-created placeholder graph.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0</para>
            /// </summary>
            [NameInMap("activeVersion")]
            [Validation(Required=false)]
            public string ActiveVersion { get; set; }

            /// <summary>
            /// <para>The business description of the graph. An empty string is returned if this parameter is not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer domain semantic graph</para>
            /// </summary>
            [NameInMap("businessProfile")]
            [Validation(Required=false)]
            public string BusinessProfile { get; set; }

            /// <summary>
            /// <para>The display name of the tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRM Graph</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The graph name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm_graph</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>The status of the semantic graph.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("graphStatus")]
            [Validation(Required=false)]
            public string GraphStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the graph contains a draft.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasDraft")]
            [Validation(Required=false)]
            public bool? HasDraft { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The number of object types. The value falls back to 0 if parsing fails.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("objectTypeCount")]
            [Validation(Required=false)]
            public long? ObjectTypeCount { get; set; }

            /// <summary>
            /// <para>The number of relations. The value falls back to 0 if parsing fails.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("relationCount")]
            [Validation(Required=false)]
            public long? RelationCount { get; set; }

            /// <summary>
            /// <para>The list of semantic tags. An empty array [] is returned if this parameter is not configured.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("semanticTags")]
            [Validation(Required=false)]
            public List<string> SemanticTags { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
