// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageCroppingRequest : Darabonba.Model {
        /// <summary>
        /// <para>The URL of the image to process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/image.jpg">https://example.com/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The target height.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>The target width.</para>
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

