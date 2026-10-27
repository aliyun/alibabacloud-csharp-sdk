// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of sessions to return. Default value: 20.</para>
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
        /// <para>The alias or version of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The ID of the session used for filtering. If you specify this parameter, all active or expired status information associated with the session is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session-id-1</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session status to filter. By default, all session information in the Active or Expired state is returned. You can specify Active to retrieve only active session information, or specify Expired to retrieve only expired session information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

    }

}
