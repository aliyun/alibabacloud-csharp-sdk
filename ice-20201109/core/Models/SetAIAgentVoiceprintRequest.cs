// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetAIAgentVoiceprintRequest : TeaModel {
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SetAIAgentVoiceprintRequestInput Input { get; set; }
        public class SetAIAgentVoiceprintRequestInput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/audio/sample.wav</a></para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wav</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>url</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
