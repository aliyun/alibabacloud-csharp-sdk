// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A59143F1</para>
        /// </summary>
        [NameInMap("ServerSn")]
        [Validation(Required=false)]
        public string ServerSn { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i207023871669364793713</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03f53c719015a9ad4f4f55d66cac2dac161b18e8065ca75a3220b89de389c980</para>
        /// </summary>
        [NameInMap("SessionToken")]
        [Validation(Required=false)]
        public string SessionToken { get; set; }

        /// <summary>
        /// <para>The WebSocket address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws://x.x.x.x:xx/calypso_web_console</para>
        /// </summary>
        [NameInMap("WssEndpoint")]
        [Validation(Required=false)]
        public string WssEndpoint { get; set; }

    }

}
