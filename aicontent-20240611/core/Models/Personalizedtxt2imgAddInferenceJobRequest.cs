// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgAddInferenceJobRequest : TeaModel {
        /// <summary>
        /// <para>The number of images to generate. Note: Due to resource limits in the test environment, a maximum of 10 images can be generated at a time. If this value is greater than 10, it is treated as 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageNumber")]
        [Validation(Required=false)]
        public int? ImageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the model training task. Specifies the model to use for inference.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The English prompt that describes the image to be generated. Replace the character to be generated with <special-token>. For example, change &quot;a man in the snow&quot; to &quot;a <special-token> in the snow&quot; and &quot;a photo of a girl&quot; to &quot;a photo of a <special-token>&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a <special-token> in the snow</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The random seed. A fixed seed generates the same image and ensures the reproducibility of the results. Note: The input value must be in the range of [-1, 2147483647]. If the input value is out of this range or not provided, a suitable seed is automatically generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public long? Seed { get; set; }

    }

}
