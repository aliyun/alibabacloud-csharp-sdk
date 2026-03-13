// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultimodalAsyncModerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>post_text_image_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;mainData&quot;:{&quot;mainContent&quot;:&quot;testMainContent&quot;,&quot;mainTitle&quot;:&quot;testMainTitle&quot;,&quot;mainImages&quot;:[{&quot;imageUrl&quot;:&quot;<a href="https://xxxx.com/001.jpg%22%7D%5D%7D%7D">https://xxxx.com/001.jpg&quot;}]}}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
