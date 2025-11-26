// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class OmniRealtimeConversationEURequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250211/tixcef/cherry.wav">https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250211/tixcef/cherry.wav</a></para>
        /// </summary>
        [NameInMap("inputAudio")]
        [Validation(Required=false)]
        public string InputAudio { get; set; }

        [NameInMap("userPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Cherry</para>
        /// </summary>
        [NameInMap("voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

    }

}
