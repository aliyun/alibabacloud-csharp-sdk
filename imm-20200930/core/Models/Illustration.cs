// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Illustration : TeaModel {
        /// <summary>
        /// <para>The zero-based image index in a file that contains multiple images, such as a multi-page TIFF file.</para>
        /// </summary>
        [NameInMap("ImageIndex")]
        [Validation(Required=false)]
        public int? ImageIndex { get; set; }

        /// <summary>
        /// <para>The path to the image file containing the illustration.</para>
        /// </summary>
        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// <para>An array of four floating-point numbers that defines the normalized box for the illustration in [x_min, y_min, x_max, y_max] format. The coordinates are normalized to a range of [0, 1] relative to the page dimensions.</para>
        /// </summary>
        [NameInMap("NormalizedBox")]
        [Validation(Required=false)]
        public List<float?> NormalizedBox { get; set; }

        /// <summary>
        /// <para>The one-based page number where the illustration is located.</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The text associated with the illustration.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The type of the illustration, such as <c>figure</c> or <c>chart</c>.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
