// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowOutputRequest : TeaModel {
        /// <summary>
        /// <para>IP whitelist, in CIDR format, separated by commas if multiple IP segments are provided</para>
        /// 
        /// <b>Example:</b>
        /// <para>83.17.231.31/32</para>
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
        /// <para>Output protocol</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RTMP-PULL</para>
        /// </summary>
        [NameInMap("OutputProtocol")]
        [Validation(Required=false)]
        public string OutputProtocol { get; set; }

        /// <summary>
        /// <para>Output address, required when the output type is RTMP-PUSH/SRT-Caller mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://push.test.alivecdn.com/live/alitest</para>
        /// </summary>
        [NameInMap("OutputToUrl")]
        [Validation(Required=false)]
        public string OutputToUrl { get; set; }

        /// <summary>
        /// <para>Paired Flow instance ID, required when the output type is Flow</para>
        /// 
        /// <b>Example:</b>
        /// <para>8666ec062190f00e263012666319a5be</para>
        /// </summary>
        [NameInMap("PairFlowId")]
        [Validation(Required=false)]
        public string PairFlowId { get; set; }

        /// <summary>
        /// <para>Input name of the paired Flow, required when the output type is Flow</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliTestInput</para>
        /// </summary>
        [NameInMap("PairInputName")]
        [Validation(Required=false)]
        public string PairInputName { get; set; }

        /// <summary>
        /// <para>Maximum number of players</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PlayerLimit")]
        [Validation(Required=false)]
        public int? PlayerLimit { get; set; }

        /// <summary>
        /// <para>SRT latency, required only when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SrtLatency")]
        [Validation(Required=false)]
        public int? SrtLatency { get; set; }

        /// <summary>
        /// <para>SRT passphrase, required only when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>BETTERG08S01</para>
        /// </summary>
        [NameInMap("SrtPassphrase")]
        [Validation(Required=false)]
        public string SrtPassphrase { get; set; }

        /// <summary>
        /// <para>SRT encryption length, required only when the input type is SRT-Listener/SRT-Caller</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SrtPbkeyLen")]
        [Validation(Required=false)]
        public string SrtPbkeyLen { get; set; }

    }

}
