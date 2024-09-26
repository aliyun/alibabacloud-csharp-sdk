// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP URL. You can use this URL to enter the container within 30 seconds after this operation is called. For more information, see <a href="https://help.aliyun.com/document_detail/202846.html">Use and integrate the Elastic Container Instance terminal</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://eci.console.aliyun.com/terminal?param=X32a">https://eci.console.aliyun.com/terminal?param=X32a</a>****</para>
        /// </summary>
        [NameInMap("HttpUrl")]
        [Validation(Required=false)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28B583A8-313D-4383-7817-B5A9F7E0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The output of the command. This parameter is returned only if Sync is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("SyncResponse")]
        [Validation(Required=false)]
        public string SyncResponse { get; set; }

        /// <summary>
        /// <para>The WebSocket URL. You can use this URL to establish a WebSocket connection with the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wss://eci-cn-shanghai.aliyun.com/exec/?s=ktHPx****</para>
        /// </summary>
        [NameInMap("WebSocketUri")]
        [Validation(Required=false)]
        public string WebSocketUri { get; set; }

    }

}
