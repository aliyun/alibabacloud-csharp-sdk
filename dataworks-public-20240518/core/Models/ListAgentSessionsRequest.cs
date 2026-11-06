// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The request ID provided by the caller. This ID is returned as is in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676303114031776</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version, which is fixed to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ListAgentSessionsRequestParams Params { get; set; }
        public class ListAgentSessionsRequestParams : TeaModel {
            /// <summary>
            /// <para>The <b>agent name</b> for exact match filtering. You must specify at least one of this parameter and <c>SessionSourceList</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat_cli_chatbi</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>Specifies whether to query archived sessions. If you set this parameter to true, only archived sessions are returned. If you set this parameter to false or omit it, only unarchived sessions are returned. A value of false does not mean all sessions. To query both types of sessions, send separate requests and handle the pagination for each.</para>
            /// </summary>
            [NameInMap("Archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page. Set this parameter to 1 for the first page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The session ID for exact matching.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The <b>session source list</b> for filtering. You must specify at least one of this parameter and <c>AgentName</c>.</para>
            /// </summary>
            [NameInMap("SessionSourceList")]
            [Validation(Required=false)]
            public List<string> SessionSourceList { get; set; }

            /// <summary>
            /// <para>The session title for fuzzy match filtering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales in the last 30 days</para>
            /// </summary>
            [NameInMap("SessionTitle")]
            [Validation(Required=false)]
            public string SessionTitle { get; set; }

            /// <summary>
            /// <para>The session tag code list for filtering.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

        }

    }

}
