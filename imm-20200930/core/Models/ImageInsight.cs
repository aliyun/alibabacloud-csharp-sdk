// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ImageInsight : TeaModel {
        /// <summary>
        /// <para>Image summary.</para>
        /// <remarks>
        /// <para> Not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>无。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片中有一人，穿着深色西装外套，内搭白色衬衫。背景为渐变的浅蓝色至灰色。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
