// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaConnectFlowOutputRequest : TeaModel {
        /// <summary>
        /// <para>IP whitelist</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.168.1.1/32,18.168.1.1/16</para>
        /// </summary>
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public string Cidrs { get; set; }

        /// <summary>
        /// <para>Flow instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>Output name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliTestOutput</para>
        /// </summary>
        [NameInMap("OutputName")]
        [Validation(Required=false)]
        public string OutputName { get; set; }

        /// <summary>
        /// <para>Output address, modifiable when the output type is RTMP-PUSH/SRT-Caller mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://push.test.alivecdn.com/live/alitest</para>
        /// </summary>
        [NameInMap("OutputToUrl")]
        [Validation(Required=false)]
        public string OutputToUrl { get; set; }

        /// <summary>
        /// <para>Player limit</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PlayerLimit")]
        [Validation(Required=false)]
        public string PlayerLimit { get; set; }

        /// <summary>
        /// <para>SRT latency, modifiable when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SrtLatency")]
        [Validation(Required=false)]
        public string SrtLatency { get; set; }

        /// <summary>
        /// <para>SRT encryption key, modifiable when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>FICUBPX4Q77DYHRF</para>
        /// </summary>
        [NameInMap("SrtPassphrase")]
        [Validation(Required=false)]
        public string SrtPassphrase { get; set; }

        /// <summary>
        /// <para>SRT encryption length, modifiable when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SrtPbkeyLen")]
        [Validation(Required=false)]
        public string SrtPbkeyLen { get; set; }

    }

}
