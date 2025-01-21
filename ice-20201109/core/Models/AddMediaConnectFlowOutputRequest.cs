// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowOutputRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>83.17.231.31/32</para>
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
        /// <para>AliTestOutput</para>
        /// </summary>
        [NameInMap("OutputName")]
        [Validation(Required=false)]
        public string OutputName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RTMP-PULL</para>
        /// </summary>
        [NameInMap("OutputProtocol")]
        [Validation(Required=false)]
        public string OutputProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rtmp://push.test.alivecdn.com/live/alitest</para>
        /// </summary>
        [NameInMap("OutputToUrl")]
        [Validation(Required=false)]
        public string OutputToUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8666ec062190f00e263012666319a5be</para>
        /// </summary>
        [NameInMap("PairChannelId")]
        [Validation(Required=false)]
        public string PairChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8666ec062190f00e263012666319a5be</para>
        /// </summary>
        [NameInMap("PairFlowId")]
        [Validation(Required=false)]
        public string PairFlowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliTestInput</para>
        /// </summary>
        [NameInMap("PairInputName")]
        [Validation(Required=false)]
        public string PairInputName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PlayerLimit")]
        [Validation(Required=false)]
        public int? PlayerLimit { get; set; }

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

    }

}
