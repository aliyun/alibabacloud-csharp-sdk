// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateVoiceAccessProfileRequest : TeaModel {
        /// <summary>
        /// <para>The access profile ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The voice engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOLC</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        /// <summary>
        /// <para>The parameter configuration for the selected voice engine.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public UpdateVoiceAccessProfileRequestProfile Profile { get; set; }
        public class UpdateVoiceAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <para>This parameter is required when <c>NlsEngine</c> is set to <c>VOLC</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HwRnTXgwnQOlsj68URDS5_VMm4Wtapq9</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>This parameter is required when <c>NlsEngine</c> is set to <c>BAILIAN</c> or <c>IFLYTEK</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-12341e259b1049e8872b47981e545f78</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>This parameter is required when <c>NlsEngine</c> is set to <c>IFLYTEK</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0358c6e51c1013b446fdeb21a3a1234</para>
            /// </summary>
            [NameInMap("ApiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// <para>This parameter is required when <c>NlsEngine</c> is set to <c>IFLYTEK</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b123bfb</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>This parameter is required when <c>NlsEngine</c> is set to <c>VOLC</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2541370123</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>Reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>暂无使用</para>
            /// </summary>
            [NameInMap("AsrAppKey")]
            [Validation(Required=false)]
            public string AsrAppKey { get; set; }

            /// <summary>
            /// <para>Reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>暂无使用</para>
            /// </summary>
            [NameInMap("TtsApiKey")]
            [Validation(Required=false)]
            public string TtsApiKey { get; set; }

        }

    }

}
