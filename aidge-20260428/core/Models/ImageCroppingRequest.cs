// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageCroppingRequest : TeaModel {
        /// <summary>
        /// <para>URL of the image to be processed</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/image.jpg">https://example.com/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Target height</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>Target width</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetWidth")]
        [Validation(Required=false)]
        public int? TargetWidth { get; set; }

    }

}
