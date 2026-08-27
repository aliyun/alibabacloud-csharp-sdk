// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChatMessagesRequest : TeaModel {
        /// <summary>
        /// <para>Set to V2 to route requests to the ROS Agent V2 backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>A compatibility field. V2 does not return a paged message array, and the service does not consume this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatibility field. V2 does not return a paged message array, and the service does not consume this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAES...</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The session ID to query. You can only query sessions owned by the current user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7f4e2a8c6d9b4a1f8e3c5b7d2a6f9012</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
