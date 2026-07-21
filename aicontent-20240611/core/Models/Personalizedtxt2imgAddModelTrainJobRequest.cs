// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgAddModelTrainJobRequest : TeaModel {
        /// <summary>
        /// <para>A list of one or more image URLs for training. For example: [&quot;url_1&quot;, &quot;url_2&quot;, ...]</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public List<string> ImageUrl { get; set; }

        /// <summary>
        /// <para>The name of the model training job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>熊猫图片生成</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A single word that defines the object type in the training images, such as &quot;girl&quot;, &quot;person&quot;, &quot;man&quot;, &quot;boy&quot;, or &quot;dog&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dog</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The number of training steps for the model training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("trainSteps")]
        [Validation(Required=false)]
        public int? TrainSteps { get; set; }

    }

}
