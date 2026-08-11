// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateVoiceAccessProfileRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The voice service provider.
        /// BAILIAN: Bailian.
        /// VOLC: Doubao.
        /// IFLYTEK: iFLYTEK.
        /// TENCENT: Tencent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAILIAN</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        /// <summary>
        /// <para>The provider configuration information.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public CreateVoiceAccessProfileRequestProfile Profile { get; set; }
        public class CreateVoiceAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <para>Required when NlsEngine=VOLC.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=IFLYTEK or NlsEngine=BAILIAN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a9872e2342952e248727798f642936c7</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=IFLYTEK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0358c6e51c1013b446fdeb21a3a5d2e</para>
            /// </summary>
            [NameInMap("ApiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=IFLYTEK or NlsEngine=TENCENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9479688350</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=VOLC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW0yKRHQEe1nAd8c</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>Not currently in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not currently in use</para>
            /// </summary>
            [NameInMap("AsrAppKey")]
            [Validation(Required=false)]
            public string AsrAppKey { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=TENCENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sci_r3b3e62udqcujnkerrorqztnpu</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>Required when NlsEngine=TENCENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>y5MZfFdW6yBZgJdKonHZBA</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>Not currently in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not currently in use</para>
            /// </summary>
            [NameInMap("TtsApiKey")]
            [Validation(Required=false)]
            public string TtsApiKey { get; set; }

        }

    }

}
