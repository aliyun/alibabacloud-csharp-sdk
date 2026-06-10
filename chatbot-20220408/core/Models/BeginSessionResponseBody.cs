// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class BeginSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ASR end-pointing detection time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700</para>
        /// </summary>
        [NameInMap("AsrMaxEndSilence")]
        [Validation(Required=false)]
        public int? AsrMaxEndSilence { get; set; }

        /// <summary>
        /// <para>Indicates whether voice playback is interruptible.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>149C7528-C104-1B50-A4F9-0C5907A8AD9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The silence timeout, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SilenceReplyTimeout")]
        [Validation(Required=false)]
        public int? SilenceReplyTimeout { get; set; }

        /// <summary>
        /// <para>The welcome message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>智能对话机器人为您服务，请问有什么可以帮您？</para>
        /// </summary>
        [NameInMap("WelcomeMessage")]
        [Validation(Required=false)]
        public string WelcomeMessage { get; set; }

    }

}
