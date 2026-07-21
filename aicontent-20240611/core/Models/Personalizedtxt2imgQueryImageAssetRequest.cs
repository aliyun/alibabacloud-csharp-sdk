// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgQueryImageAssetRequest : TeaModel {
        /// <summary>
        /// <para>The encoding format of the image. If this parameter is set to <c>base64</c>, the image is returned as a Base64-encoded string. If this parameter is omitted, the raw binary data of the image is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("encodeFormat")]
        [Validation(Required=false)]
        public string EncodeFormat { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000.png</para>
        /// </summary>
        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>girl-xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The ID of the prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("promptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

    }

}
