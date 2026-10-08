// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsightsCaptionConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable video captioning.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The person reference configuration.</para>
        /// </summary>
        [NameInMap("PersonReference")]
        [Validation(Required=false)]
        public PersonReferenceConfig PersonReference { get; set; }

        /// <summary>
        /// <para>The custom prompt for video captioning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请用一句话描述这个视频</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
