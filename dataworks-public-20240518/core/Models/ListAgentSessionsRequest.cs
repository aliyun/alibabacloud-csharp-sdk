// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed in by the requester. The value is returned as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676303114031776</para>
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
        /// <para>The business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ListAgentSessionsRequestParams Params { get; set; }
        public class ListAgentSessionsRequestParams : TeaModel {
            /// <summary>
            /// <para><b>Agent name</b> for exact filtering. At least one of this parameter and <c>SessionSourceList</c> must be specified.</para>
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
            /// <para><b>Session source list</b> for filtering. At least one of this parameter and <c>AgentName</c> must be specified.</para>
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
            /// <para>The list of session tag codes for filtering.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

        }

    }

}
