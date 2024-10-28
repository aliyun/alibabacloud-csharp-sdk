// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduInterpreting20240828.Models
{
    public class RecognizeAudioRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xx.com/abc.mp3">http://xx.com/abc.mp3</a></para>
        /// </summary>
        [NameInMap("AudioFileUrl")]
        [Validation(Required=false)]
        public string AudioFileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://abc.edu.org.cn/en/callback">https://abc.edu.org.cn/en/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCallBack")]
        [Validation(Required=false)]
        public bool? EnableCallBack { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>433c1361-0f6e-48fc-ad51</para>
        /// </summary>
        [NameInMap("OuterBizId")]
        [Validation(Required=false)]
        public string OuterBizId { get; set; }

    }

}
