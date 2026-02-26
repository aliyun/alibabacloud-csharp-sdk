// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Insights : TeaModel {
        /// <summary>
        /// <para>The summary and description of the image.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public ImageInsight Image { get; set; }

        /// <summary>
        /// <para>The summary and description of the video.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public VideoInsight Video { get; set; }

    }

}
