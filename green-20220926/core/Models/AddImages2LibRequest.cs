// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddImages2LibRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image. This value must be the Key field returned by GetUploadInfo, in the format of image/upload/<hash>. Passing an external image URL returns a 400 image.url.invalid error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/upload/755c31906fc0b0b5007ecead9660c2ab</para>
        /// </summary>
        [NameInMap("ImgUrl")]
        [Validation(Required=false)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// <para>The ID of the image library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_imglib_001</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
