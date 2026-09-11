// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetGraphSchemaDetailResponseBody : TeaModel {
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
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The hash fingerprint of the schema content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3</para>
        /// </summary>
        [NameInMap("contentHash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u001</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRM Graph</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T10:00:00+00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T11:30:00+00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The name of the graph.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The status of the semantic graph.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHING: A publish task is in progress for this graph.
        /// DEVELOPING: An active draft exists for this graph (being edited, not yet published).
        /// PUBLISHED: Normal status</para>
        /// </summary>
        [NameInMap("graphStatus")]
        [Validation(Required=false)]
        public string GraphStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the graph contains a draft.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasDraft")]
        [Validation(Required=false)]
        public bool? HasDraft { get; set; }

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

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The original YAML text of the graph schema trimmed by READ permission. The $ref references within the authorized subgraph are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name: crm_graph</para>
        /// </summary>
        [NameInMap("yamlEdit")]
        [Validation(Required=false)]
        public string YamlEdit { get; set; }

    }

}
