// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ReverseImageConfig : TeaModel {
        /// <summary>
        /// <para>The image-to-image search configuration.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public ImageReverseImageConfig Image { get; set; }

        /// <summary>
        /// <para>The image-to-video search configuration.</para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public VideoReverseImageConfig Video { get; set; }

    }

}
