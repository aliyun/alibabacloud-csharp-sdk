// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetWebTerminalResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID for this call, used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The WebSocket link for accessing the container. You need to build a WebSocket client. For the detailed communication format, refer to the following code:</para>
        /// <pre><c>ws = new WebSocket(
        ///   `wss://xxxxx`,
        /// );
        /// ws.onopen = function open() {
        ///   console.warn(\\&quot;connected\\&quot;);
        ///   term.write(\\&quot;\\&quot;);
        /// };
        /// 
        /// ws.onclose = function close() {
        ///   console.warn(\\&quot;disconnected\\&quot;);
        ///   term.write(\\&quot;Connection closed\\&quot;);
        /// };
        /// 
        /// // Receive response from the backend
        /// ws.onmessage = function incoming(event) {
        ///   const msg = JSON.parse(event.data);
        ///   console.warn(msg);
        ///   if (msg.operation === \\&quot;stdout\\&quot;) {
        ///     term.write(msg.data);
        ///   } else {
        ///     console.warn(\\&quot;invalid msg operation: \\&quot; + msg);
        ///   }
        /// };
        /// 
        /// // Console input
        /// term.onData(data =&gt; {
        ///   const msg = { operation: \\&quot;stdin\\&quot;, data: data };
        ///   ws.send(JSON.stringify(msg));
        /// });
        /// 
        /// term.onResize(size =&gt; {
        ///   const msg = { operation: \\&quot;resize\\&quot;, cols: size.cols, rows: size.rows };
        ///   ws.send(JSON.stringify(msg));
        /// });
        /// 
        /// fitAddon.fit();
        /// };
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>wss://*****</para>
        /// </summary>
        [NameInMap("WebTerminalUrl")]
        [Validation(Required=false)]
        public string WebTerminalUrl { get; set; }

    }

}
