// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class PersonalizedTextToImageAddInferenceJobRequest : TeaModel {
        /// <summary>
        /// <para>The number of images to generate. Note: The maximum is 10 images per request in the test environment. If the value exceeds 10, it is treated as 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageNumber")]
        [Validation(Required=false)]
        public int? ImageNumber { get; set; }

        /// <summary>
        /// <para>An array containing one or more image URLs. For example, <c>[&quot;url_1&quot;, &quot;url_2&quot;, ...]</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public List<string> ImageUrl { get; set; }

        /// <summary>
        /// <para>The English prompt for image generation. Use the placeholder for the subject. For example, change &quot;a man in the snow&quot; to &quot;a in the snow&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a <special-token> in the snow</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>A random seed to ensure reproducible image generation. The value must be within <c>[-1, 2147483647]</c>. If the value is outside this range or omitted, the system automatically generates a seed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public long? Seed { get; set; }

        /// <summary>
        /// <para>Determines the influence of the reference image.
        /// Valid values: <c>0.3</c>, <c>0.4</c>, <c>0.5</c>, <c>0.6</c>, <c>0.7</c>, and <c>0.8</c>.
        /// A lower value decreases the influence of the reference image and increases the influence of the text prompt.
        /// The default is <c>0.5</c>, and you typically do not need to change this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("strength")]
        [Validation(Required=false)]
        public double? Strength { get; set; }

        /// <summary>
        /// <para>The number of training steps for the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("trainSteps")]
        [Validation(Required=false)]
        public int? TrainSteps { get; set; }

    }

}
