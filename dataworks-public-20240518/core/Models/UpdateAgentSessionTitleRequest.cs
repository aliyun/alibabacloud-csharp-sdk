// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAgentSessionTitleRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC correlation ID for the current request. It is specified by the caller and used to correlate the request and response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updateagentsessiontitle-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Set the value to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The request parameters for modifying the session title, including the target session ID and the new title.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public UpdateAgentSessionTitleRequestParams Params { get; set; }
        public class UpdateAgentSessionTitleRequestParams : TeaModel {
            /// <summary>
            /// <para>The ID of the agent session that belongs to the current account.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123e4567-e89b-42d3-a456-426614174000</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The new title. The length must be 1 to 512 characters after leading and trailing whitespaces are removed.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>New title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
