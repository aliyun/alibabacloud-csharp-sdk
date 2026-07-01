// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowInputResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowInputResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowInputResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The IP address whitelist for the backup input.</para>
            /// </summary>
            [NameInMap("BackupCidrs")]
            [Validation(Required=false)]
            public string BackupCidrs { get; set; }

            /// <summary>
            /// <para>The time when the backup input was created.</para>
            /// </summary>
            [NameInMap("BackupCreateTime")]
            [Validation(Required=false)]
            public string BackupCreateTime { get; set; }

            [NameInMap("BackupInnerInputUrl")]
            [Validation(Required=false)]
            public string BackupInnerInputUrl { get; set; }

            /// <summary>
            /// <para>The name of the backup input.</para>
            /// </summary>
            [NameInMap("BackupInputName")]
            [Validation(Required=false)]
            public string BackupInputName { get; set; }

            /// <summary>
            /// <para>The status of the backup input. It indicates whether the backup stream is being pushed.</para>
            /// </summary>
            [NameInMap("BackupInputStatus")]
            [Validation(Required=false)]
            public string BackupInputStatus { get; set; }

            /// <summary>
            /// <para>The URL of the backup input.</para>
            /// </summary>
            [NameInMap("BackupInputUrl")]
            [Validation(Required=false)]
            public string BackupInputUrl { get; set; }

            /// <summary>
            /// <para>The bitrate of the backup input.</para>
            /// </summary>
            [NameInMap("BackupMaxBitrate")]
            [Validation(Required=false)]
            public int? BackupMaxBitrate { get; set; }

            /// <summary>
            /// <para>The SRT latency for the backup input.</para>
            /// </summary>
            [NameInMap("BackupSrtLatency")]
            [Validation(Required=false)]
            public int? BackupSrtLatency { get; set; }

            /// <summary>
            /// <para>The SRT encryption key for the backup input.</para>
            /// </summary>
            [NameInMap("BackupSrtPassphrase")]
            [Validation(Required=false)]
            public string BackupSrtPassphrase { get; set; }

            /// <summary>
            /// <para>The SRT encryption key length for the backup input.</para>
            /// </summary>
            [NameInMap("BackupSrtPbkeyLen")]
            [Validation(Required=false)]
            public int? BackupSrtPbkeyLen { get; set; }

            /// <summary>
            /// <para>The IP address whitelist in CIDR format. Separate multiple IP address segments with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.211.0.0/17</para>
            /// </summary>
            [NameInMap("Cidrs")]
            [Validation(Required=false)]
            public string Cidrs { get; set; }

            /// <summary>
            /// <para>The time when the input was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T01:29:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("InnerInputUrl")]
            [Validation(Required=false)]
            public string InnerInputUrl { get; set; }

            /// <summary>
            /// <para>The input name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestInput</para>
            /// </summary>
            [NameInMap("InputName")]
            [Validation(Required=false)]
            public string InputName { get; set; }

            /// <summary>
            /// <para>The input type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RTMP-PUSH</para>
            /// </summary>
            [NameInMap("InputProtocol")]
            [Validation(Required=false)]
            public string InputProtocol { get; set; }

            /// <summary>
            /// <para>The input status. It indicates whether the primary stream is being pushed.</para>
            /// </summary>
            [NameInMap("InputStatus")]
            [Validation(Required=false)]
            public string InputStatus { get; set; }

            /// <summary>
            /// <para>The input URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://1.2.3.4:1935/live/AliTestInput_8666ec062190f00e263012666319a5be</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// <para>The input bitrate, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>The ID of the peer Flow instance. This parameter is required only if the output type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05c3adf4-aa0e-421d-a991-48ceae3e642e</para>
            /// </summary>
            [NameInMap("PairFlowId")]
            [Validation(Required=false)]
            public string PairFlowId { get; set; }

            /// <summary>
            /// <para>The output name of the peer Flow. This parameter is required only when the input type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestOutput</para>
            /// </summary>
            [NameInMap("PairOutputName")]
            [Validation(Required=false)]
            public string PairOutputName { get; set; }

            /// <summary>
            /// <para>The SRT latency in milliseconds (ms). This parameter is required only when the input type is SRT-Listener or SRT-Caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SrtLatency")]
            [Validation(Required=false)]
            public int? SrtLatency { get; set; }

            /// <summary>
            /// <para>The SRT encryption key. This parameter is required only when the input type is SRT-Listener or SRT-Caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FICUBPX4Q77DYHRF</para>
            /// </summary>
            [NameInMap("SrtPassphrase")]
            [Validation(Required=false)]
            public string SrtPassphrase { get; set; }

            /// <summary>
            /// <para>The SRT encryption key length. This parameter is required only when the input type is SRT-Listener or SRT-Caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SrtPbkeyLen")]
            [Validation(Required=false)]
            public int? SrtPbkeyLen { get; set; }

        }

        /// <summary>
        /// <para>The description of the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4C231DF-103A-55FF-8D09-E699552457DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code returned. A value of 0 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
