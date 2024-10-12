// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class PersonalizedTextToImageQueryImageAssetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("encodeFormat")]
        [Validation(Required=false)]
        public string EncodeFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000.png</para>
        /// </summary>
        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

    }

}
