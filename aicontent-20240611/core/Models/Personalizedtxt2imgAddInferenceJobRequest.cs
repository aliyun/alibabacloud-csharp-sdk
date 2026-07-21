// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgAddInferenceJobRequest : TeaModel {
        /// <summary>
        /// <para>The number of images to generate. Note: Due to resource limits in the test environment, you can generate up to 10 images per request. The system automatically sets values greater than 10 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageNumber")]
        [Validation(Required=false)]
        public int? ImageNumber { get; set; }

        /// <summary>
        /// <para>The model ID to use for the inference job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>An English prompt describing the image to generate. Replace the subject with . For example, change &quot;a man in the snow&quot; to &quot;a in the snow&quot;, and &quot;a photo of a girl&quot; to &quot;a photo of a &quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a <special-token> in the snow</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The seed for the random number generator. Using the same seed ensures reproducible results. The value must be between -1 and 2,147,483,647. If the value is outside this range or is not specified, the system automatically generates a suitable seed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public long? Seed { get; set; }

    }

}
