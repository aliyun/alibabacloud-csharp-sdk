// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetAIAgentVoiceprintRequest : TeaModel {
        /// <summary>
        /// <para>The input file.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SetAIAgentVoiceprintRequestInput Input { get; set; }
        public class SetAIAgentVoiceprintRequestInput : TeaModel {
            /// <summary>
            /// <para>The media access link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav</a></para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The audio file format. Only WAV is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wav</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Specifies the access type for the audio file. The system will verify file accessibility via HEAD or GET requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>url: An HTTP(S) link to the audio file.</para>
            /// </description></item>
            /// <item><description><para>oss: An OSS object. Supports the following formats:</para>
            /// <ol>
            /// <item><description><para>OSS URI: oss://bucket-name/object-key</para>
            /// <para>Example: oss://my-bucket/audio/sample.wav</para>
            /// </description></item>
            /// <item><description><para>OSS public URL: http(s)://${bucket}.oss-${region}.aliyuncs.com/${object}</para>
            /// <para>Example: <a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav</a></para>
            /// </description></item>
            /// </ol>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> The OSS bucket must be in the same region as the service. Otherwise, the access fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>url</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A unique identifier for the voiceprint. Generate this ID based on your own business rules. Requirement: 1 to 127 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
