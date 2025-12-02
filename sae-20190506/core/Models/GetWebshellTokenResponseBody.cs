// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetWebshellTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWebshellTokenResponseBodyData Data { get; set; }
        public class GetWebshellTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Webshell page address</para>
            /// 
            /// <b>Example:</b>
            /// <para>HttpUrl :  &quot;<a href="https://saenext.console.aliyun.com/cn-shenzhen/app-list/app1/micro-app/shell/pod1?tokenId=xxx">https://saenext.console.aliyun.com/cn-shenzhen/app-list/app1/micro-app/shell/pod1?tokenId=xxx</a></para>
            /// </summary>
            [NameInMap("HttpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }

            /// <summary>
            /// <para>The information about the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zWWpvRj_5pzof4hfo7-hGynM8oGMmO_7</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The WebSocket address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wss://sae-webshell.console.aliyun.com/websocket/eamWebshell?tokenId=xxx&amp;region=cn-shenzhen</para>
            /// </summary>
            [NameInMap("WebSocketUrl")]
            [Validation(Required=false)]
            public string WebSocketUrl { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the call failed. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, the <b>ErrorCode</b> parameter is returned. For more information, see <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Value description:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, a success message is returned.</description></item>
        /// <item><description>An error code is returned if the request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
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

        /// <summary>
        /// <para>The ID of the trace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
