// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class PrecheckYikeAIAppJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;794da8a01b8c71f1b973e6e7c7586301\&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

    }

}
