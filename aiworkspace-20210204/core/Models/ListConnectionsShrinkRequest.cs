// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConnectionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of connection IDs.</para>
        /// </summary>
        [NameInMap("ConnectionIds")]
        [Validation(Required=false)]
        public string ConnectionIdsShrink { get; set; }

        /// <summary>
        /// <para>The connection name.</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The list of connection types.</para>
        /// </summary>
        [NameInMap("ConnectionTypes")]
        [Validation(Required=false)]
        public string ConnectionTypesShrink { get; set; }

        /// <summary>
        /// <para>The encryption settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText</description></item>
        /// <item><description>Secret</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("EncryptOption")]
        [Validation(Required=false)]
        public string EncryptOption { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_001</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The list of model types.</para>
        /// </summary>
        [NameInMap("ModelTypes")]
        [Validation(Required=false)]
        public string ModelTypesShrink { get; set; }

        /// <summary>
        /// <para>The pagination token that indicates the start position from which to retrieve data on the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order in which the entries are sorted by the specific field on the returned page. This parameter must be used together with SortBy.</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field used to sort the results in queries by page. Default value: GmtCreateTime. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreateTime: The results are sorted by creation time. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether a tool can be called by using ToolCall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ToolCall")]
        [Validation(Required=false)]
        public bool? ToolCall { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
