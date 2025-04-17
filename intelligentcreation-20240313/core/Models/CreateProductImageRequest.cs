// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateProductImageRequest : TeaModel {
        [NameInMap("backgroundDescription")]
        [Validation(Required=false)]
        public string BackgroundDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75</para>
        /// </summary>
        [NameInMap("backgroundPriority")]
        [Validation(Required=false)]
        public int? BackgroundPriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx/background.png">http://xxx/background.png</a></para>
        /// </summary>
        [NameInMap("backgroundUrl")]
        [Validation(Required=false)]
        public string BackgroundUrl { get; set; }

        [NameInMap("highlightText")]
        [Validation(Required=false)]
        public string HighlightText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx/image.png">http://xxx/image.png</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("subTitle")]
        [Validation(Required=false)]
        public string SubTitle { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
