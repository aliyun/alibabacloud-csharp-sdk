// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>Visibility of the connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: visible to all workspace members.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: visible only to the creator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>List of connection IDs to filter by.</para>
        /// </summary>
        [NameInMap("ConnectionIds")]
        [Validation(Required=false)]
        public List<string> ConnectionIds { get; set; }

        /// <summary>
        /// <para>Connection name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Database connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>List of connection types to filter by.</para>
        /// </summary>
        [NameInMap("ConnectionTypes")]
        [Validation(Required=false)]
        public List<string> ConnectionTypes { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud account ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12908*******3242</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>Encryption option for sensitive fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: returns values in plaintext.</para>
        /// </description></item>
        /// <item><description><para>Secret: returns values in ciphertext.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("EncryptOption")]
        [Validation(Required=false)]
        public string EncryptOption { get; set; }

        /// <summary>
        /// <para>Maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Model identifier. Filters connections associated with this model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_001</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>List of model types to filter by.</para>
        /// </summary>
        [NameInMap("ModelTypes")]
        [Validation(Required=false)]
        public List<string> ModelTypes { get; set; }

        /// <summary>
        /// <para>The token that marks the starting position for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Sort order. Use with the SortBy parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// <item><description><para>DESC (default): descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Field by which to sort results. Default value: GmtCreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreateTime (default): sorts by creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Whether tool calling is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: supported.</para>
        /// </description></item>
        /// <item><description><para>false: not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ToolCall")]
        [Validation(Required=false)]
        public bool? ToolCall { get; set; }

        /// <summary>
        /// <para>Workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
