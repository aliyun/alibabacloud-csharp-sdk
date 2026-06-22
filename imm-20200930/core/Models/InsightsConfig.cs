// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class InsightsConfig : TeaModel {
        [NameInMap("Image")]
        [Validation(Required=false)]
        public ImageInsightsConfig Image { get; set; }

        /// <summary>
        /// <para>The language of the source content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public VideoInsightsConfig Video { get; set; }

    }

}
