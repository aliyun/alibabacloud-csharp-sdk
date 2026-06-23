// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID provided by the caller. The value is returned as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676303114031776</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. The value must be <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>Business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ListAgentSessionsRequestParams Params { get; set; }
        public class ListAgentSessionsRequestParams : TeaModel {
            /// <summary>
            /// <para>Filters sessions by the <b>agent name</b>. You must specify at least one of this parameter and <c>SessionSourceList</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat_cli_chatbi</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The maximum number of results to return per page. Default value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page of results. Set this parameter to <c>1</c> to retrieve the first page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Filters sessions by session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Filters sessions by the <b>list of session sources</b>. You must specify at least one of this parameter and <c>AgentName</c>.</para>
            /// </summary>
            [NameInMap("SessionSourceList")]
            [Validation(Required=false)]
            public List<string> SessionSourceList { get; set; }

            /// <summary>
            /// <para>Filters sessions by session title using a fuzzy match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales in the last 30 days</para>
            /// </summary>
            [NameInMap("SessionTitle")]
            [Validation(Required=false)]
            public string SessionTitle { get; set; }

            /// <summary>
            /// <para>Filters sessions by a list of session tag codes.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

        }

    }

}
