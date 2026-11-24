// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ProductVideoGenerationRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio of the video. Default value: 9:16. Valid values: 16:9, 1:1, 3:4, and 9:16.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("aspect_ratio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The duration of the video in seconds. Default value: 15. If no script is provided, the value must be an integer from 5 to 15. If a script is provided, the value must be an integer from 5 to 30. A value of 15.0 is treated as 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The public URLs of the product images. At least one image is required. After leading and trailing whitespaces are removed, each URL must start with http:// or https://.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("product_images")]
        [Validation(Required=false)]
        public List<string> ProductImages { get; set; }

        /// <summary>
        /// <para>The product title. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>White minimalist ceramic mug</para>
        /// </summary>
        [NameInMap("product_title")]
        [Validation(Required=false)]
        public string ProductTitle { get; set; }

        /// <summary>
        /// <para>The resolution of the video. Default value: 720P. Valid values: 720P and 1080P. The value is case-insensitive and is automatically converted to uppercase by the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The existing storyboard script. If this parameter is not provided or is left blank, automatic planning is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create a dog</para>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

    }

}
