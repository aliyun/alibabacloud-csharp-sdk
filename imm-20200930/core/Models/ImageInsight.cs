// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ImageInsight : TeaModel {
        /// <summary>
        /// <para>The short description of the image content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An orange tabby cat lying on the living room sofa with sunlight streaming in through the window</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The image description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The image shows a person wearing a dark suit jacket over a white shirt. The background features a gradient from light blue to gray</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The multilingual image information content.</para>
        /// </summary>
        [NameInMap("MultilingualContent")]
        [Validation(Required=false)]
        public Dictionary<string, MultilingualContentEntry> MultilingualContent { get; set; }

    }

}
