// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowInputRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>19.168.1.1/32,18.168.1.1/16</para>
        /// </summary>
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public string Cidrs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rtmp://pull.test.alivecdn.com/live/alitest</para>
        /// </summary>
        [NameInMap("InputFromUrl")]
        [Validation(Required=false)]
        public string InputFromUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliTestInput</para>
        /// </summary>
        [NameInMap("InputName")]
        [Validation(Required=false)]
        public string InputName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RTMP-PUSH</para>
        /// </summary>
        [NameInMap("InputProtocol")]
        [Validation(Required=false)]
        public string InputProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000000</para>
        /// </summary>
        [NameInMap("MaxBitrate")]
        [Validation(Required=false)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>805fbdd0-575e-4146-b35d-ec7f63937b20</para>
        /// </summary>
        [NameInMap("PairFlowId")]
        [Validation(Required=false)]
        public string PairFlowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliTestOutput</para>
        /// </summary>
        [NameInMap("PairOutputName")]
        [Validation(Required=false)]
        public string PairOutputName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SrtLatency")]
        [Validation(Required=false)]
        public int? SrtLatency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BETTERG08S01</para>
        /// </summary>
        [NameInMap("SrtPassphrase")]
        [Validation(Required=false)]
        public string SrtPassphrase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SrtPbkeyLen")]
        [Validation(Required=false)]
        public string SrtPbkeyLen { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SrtPbkeylen")]
        [Validation(Required=false)]
        public string SrtPbkeylen { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BETTERG08S01</para>
        /// </summary>
        [NameInMap("SrtPbkeyssen")]
        [Validation(Required=false)]
        public string SrtPbkeyssen { get; set; }

    }

}
