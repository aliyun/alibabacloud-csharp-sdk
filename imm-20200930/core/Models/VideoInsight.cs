// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsight : TeaModel {
        /// <summary>
        /// <para>The video synopsis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The video shows two different scenes: one features a stationary white plate, a black bottle, and a transparent glass, and the other shows a hand holding a shampoo bottle labeled &quot;YEZOLU&quot; moving slowly upward in a bathroom</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The detailed description of the video content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The scene shows a slightly chubby orange cat lying on a light gray fabric sofa with its body slightly curled up</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The multilingual video information content.</para>
        /// </summary>
        [NameInMap("MultilingualContent")]
        [Validation(Required=false)]
        public Dictionary<string, MultilingualContentEntry> MultilingualContent { get; set; }

    }

}
