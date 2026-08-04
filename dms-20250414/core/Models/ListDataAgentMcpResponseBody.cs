// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentMcpResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging query results of MCP Servers.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentMcpResponseBodyData Data { get; set; }
        public class ListDataAgentMcpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP Servers on the current page. Each item contains information such as the service identifier, name, workspace, network, connection method, status, and enabled state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;uuid&quot;:&quot;44lg<em><b>z65&quot;,&quot;name&quot;:&quot;analytics&quot;,&quot;workspaceUuid&quot;:&quot;	atvx</b></em>xmz&quot;,&quot;netType&quot;:&quot;public&quot;,&quot;transportType&quot;:&quot;sse&quot;,&quot;state&quot;:&quot;ready&quot;,&quot;enable&quot;:true}]</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public object Content { get; set; }

            /// <summary>
            /// <para>The current page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public float? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public float? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records that match the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public float? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages that match the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public float? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The return code. The value is success if the request was successful, or an error code if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when a system-level request failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to list MCP servers</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The maximum number of records returned in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. This value is empty when no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>page-2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e***544</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
