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

            [NameInMap("SrtLatency")]
            [Validation(Required=false)]
            public int? SrtLatency { get; set; }

            [NameInMap("SrtMaxBitrate")]
            [Validation(Required=false)]
            public int? SrtMaxBitrate { get; set; }

            [NameInMap("SrtPassphrase")]
            [Validation(Required=false)]
            public string SrtPassphrase { get; set; }

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
