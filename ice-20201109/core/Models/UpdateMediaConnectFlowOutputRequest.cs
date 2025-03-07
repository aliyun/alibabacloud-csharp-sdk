// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaConnectFlowOutputRequest : TeaModel {
        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.168.1.1/32,18.168.1.1/16</para>
        /// </summary>
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public string Cidrs { get; set; }

        /// <summary>
        /// <para>The flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The output name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliTestOutput</para>
        /// </summary>
        [NameInMap("OutputName")]
        [Validation(Required=false)]
        public string OutputName { get; set; }

        /// <summary>
        /// <para>The output URL. You can modify this parameter only when the output type is RTMP-PUSH or SRT-Caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://push.test.alivecdn.com/live/alitest</para>
        /// </summary>
        [NameInMap("OutputToUrl")]
        [Validation(Required=false)]
        public string OutputToUrl { get; set; }

        /// <summary>
        /// <para>The maximum number of viewers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PlayerLimit")]
        [Validation(Required=false)]
        public string PlayerLimit { get; set; }

        /// <summary>
        /// <para>The latency for the SRT stream. You can modify this parameter only when the source type is SRT-Listener or SRT-Caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SrtLatency")]
        [Validation(Required=false)]
        public string SrtLatency { get; set; }

        /// <summary>
        /// <para>The SRT key. You can modify this parameter only when the source type is SRT-Listener or SRT-Caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FICUBPX4Q77DYHRF</para>
        /// </summary>
        [NameInMap("SrtPassphrase")]
        [Validation(Required=false)]
        public string SrtPassphrase { get; set; }

        /// <summary>
        /// <para>The encryption key length. You can modify this parameter only when the source type is SRT-Listener or SRT-Caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SrtPbkeyLen")]
        [Validation(Required=false)]
        public string SrtPbkeyLen { get; set; }

    }

}
