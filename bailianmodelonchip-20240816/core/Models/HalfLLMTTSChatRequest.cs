// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class HalfLLMTTSChatRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b504f84b69b9a73d3a21a2cff05e190</para>
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableSearch")]
        [Validation(Required=false)]
        public bool? EnableSearch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>.pcm。</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pitchRate")]
        [Validation(Required=false)]
        public int? PitchRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2oImhCz4f8XCviiM</para>
        /// </summary>
        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16000</para>
        /// </summary>
        [NameInMap("sampleRate")]
        [Validation(Required=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0sIRZDNncmCfBagzy534x2PH</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("speechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>661708759700322</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wss://nls-gateway-cn-beijing.aliyuncs.com/ws/v1</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>siyue</para>
        /// </summary>
        [NameInMap("voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
