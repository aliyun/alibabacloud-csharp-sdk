// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateVoiceAccessProfileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VOLC</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public CreateVoiceAccessProfileRequestProfile Profile { get; set; }
        public class CreateVoiceAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>HwRnTXgwnQOlsj68URDS5_VMm4Wtapq9</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-12341e259b1049e8872b47981e545f78</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c0358c6e51c1013b446fdeb21a3a1234</para>
            /// </summary>
            [NameInMap("ApiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5b123bfb</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2541370123</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            [NameInMap("AsrAppKey")]
            [Validation(Required=false)]
            public string AsrAppKey { get; set; }

            [NameInMap("TtsApiKey")]
            [Validation(Required=false)]
            public string TtsApiKey { get; set; }

        }

    }

}
