// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaLiveInputRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the input.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SEGK5KA6KYKAWQQH</para>
        /// </summary>
        [NameInMap("InputId")]
        [Validation(Required=false)]
        public string InputId { get; set; }

        /// <summary>
        /// <para>The input settings. An input can have up to two sources: primary and backup sources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputSettings")]
        [Validation(Required=false)]
        public List<UpdateMediaLiveInputRequestInputSettings> InputSettings { get; set; }
        public class UpdateMediaLiveInputRequestInputSettings : TeaModel {
            /// <summary>
            /// <para>The ID of the flow from MediaConnect. This parameter is required when Type is set to MEDIA_CONNECT.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>81-9693-40dc-bbab-db5e49</b></b></b></para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The output name of the MediaConnect flow. This parameter is required when Type is set to MEDIA_CONNECT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myFlowOutputName</para>
            /// </summary>
            [NameInMap("FlowOutputName")]
            [Validation(Required=false)]
            public string FlowOutputName { get; set; }

            /// <summary>
            /// <para>The source URL from which the stream is pulled. This parameter is required for PULL inputs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://domain/app/stream</para>
            /// </summary>
            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            /// <summary>
            /// <para>Latency of the SRT stream, in ms. Valid range: [100, 10000]. Optional when Type is SRT_PUSH or SRT_PULL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SrtLatency")]
            [Validation(Required=false)]
            public int? SrtLatency { get; set; }

            /// <summary>
            /// <para>Maximum bitrate of the SRT stream, in bps. Valid range: [100, 100000000]. Optional when Type is SRT_PUSH or SRT_PULL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000000</para>
            /// </summary>
            [NameInMap("SrtMaxBitrate")]
            [Validation(Required=false)]
            public int? SrtMaxBitrate { get; set; }

            /// <summary>
            /// <para>The SRT encryption configuration. The password for the SRT stream must consist of 10 to 79 visible ASCII characters. Optional when Type is SRT_PUSH or SRT_PULL.</para>
            /// <para>If the encryption configuration is not empty, all SRT clients must use the correct password to publish or playback streams. Otherwise, the SRT connection will be denied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>srtencryption</para>
            /// </summary>
            [NameInMap("SrtPassphrase")]
            [Validation(Required=false)]
            public string SrtPassphrase { get; set; }

            /// <summary>
            /// <para>Encryption configuration for SRT—the key length of the SRT stream. Valid values: 0, 16, 24, 32. Optional when Type is SRT_PUSH or SRT_PULL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("SrtPbKeyLen")]
            [Validation(Required=false)]
            public int? SrtPbKeyLen { get; set; }

            /// <summary>
            /// <para>The name of the pushed stream. This parameter is required for PUSH inputs. It can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mystream</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// <para>The name of the input. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myinput</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to be associated with the input. This parameter is required for PUSH inputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;G6G4X5T4SZYPSTT5&quot;]</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

    }

}
