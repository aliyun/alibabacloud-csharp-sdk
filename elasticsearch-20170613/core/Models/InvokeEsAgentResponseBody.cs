// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InvokeEsAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates a successful call. For non-200 values, the message field contains the error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The JSON-RPC 2.0 response body. data.result contains the actual return content of the called ACP method. data.id is the id passed in the request. data.jsonrpc is fixed to 2.0. data.timestamp is the UNIX timestamp in milliseconds when the response was generated.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// <para>The error description. The value is null when the call is successful. A specific error message is returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent subscription is inactive or expired</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1df6d614-96db-41bd-b8b6-ab061a1724ca</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
