// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The number of sessions to return. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNCNhYmM=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The function alias or version information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The session ID to filter by. If specified, all Active or Expired status information associated with this session is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session-id-1</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session status to filter by. By default, all session information in Active or Expired status is returned. Set this parameter to Active to retrieve only active session information, or to Expired to retrieve only expired session information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

    }

}
