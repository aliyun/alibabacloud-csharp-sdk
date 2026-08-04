// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentMcpResponseBody : TeaModel {
        /// <summary>
        /// <para>The MCP Server details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;uuid&quot;:&quot;	44lg<em><b>z65&quot;,&quot;name&quot;:&quot;mcp&quot;,&quot;workspaceUuid&quot;:&quot;	atvx</b></em>xmz&quot;,&quot;region&quot;:&quot;cn-hangzhou&quot;,&quot;netType&quot;:&quot;public&quot;,&quot;transportType&quot;:&quot;sse&quot;,&quot;state&quot;:&quot;ready&quot;,&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The return code. The value success is returned if the request was successful. An error code is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that describes the reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource Not exist,Mcp Server you provide is not exist</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e***000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
