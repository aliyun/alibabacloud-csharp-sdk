// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentsRequest : TeaModel {
        /// <summary>
        /// <para>The request ID passed in by the caller. The value is returned as-is in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4as3dasf654a</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Fixed value: 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The parameters for this request.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ListAgentsRequestParams Params { get; set; }
        public class ListAgentsRequestParams : TeaModel {
            /// <summary>
            /// <para>The exact agent name to filter by. If not specified, all agents are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat_cli_chatbi</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page, following the Alibaba Cloud OpenAPI convention. Do not specify this parameter for the first page. For subsequent pages, pass in the nextToken value returned in the previous response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
