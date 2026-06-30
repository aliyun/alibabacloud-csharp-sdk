// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultimodalAsyncModerationRequest : TeaModel {
        /// <summary>
        /// <para>The type of moderation service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>post_text_image_detection: multimodal moderation for post text and images</para>
        /// </description></item>
        /// <item><description><para>profile_text_image_detection: multimodal moderation for profile picture and nickname</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>post_text_image_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service. This value must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mainData&quot;:{&quot;mainContent&quot;:&quot;testMainContent&quot;,&quot;mainTitle&quot;:&quot;testMainTitle&quot;,&quot;mainImages&quot;:[{&quot;imageUrl&quot;:&quot;<a href="https://xxxx.com/001.jpg%22%7D%5D%7D%7D">https://xxxx.com/001.jpg&quot;}]}}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
