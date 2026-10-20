// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemovalProAsyncRequest : Darabonba.Model {
        /// <summary>
        /// <para>The URL of the original image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256×256 and 3000×3000, and the file size must be less than or equal to 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}

