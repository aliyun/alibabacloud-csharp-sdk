// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class AuditTTSVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4331******a4640ce1f88e27ac8df0</para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The AppKey of the third-party voice configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be******</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The TTS engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The extended parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <para>The navigation instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public string PitchRate { get; set; }

        /// <summary>
        /// <para>The AccessKey secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZDc3********DAzM2E0YjM5NTFkMDQ1</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The speech rate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public string SpeechRate { get; set; }

        /// <summary>
        /// <para>The preview text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The voice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>The volume.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public string Volume { get; set; }

    }

}
