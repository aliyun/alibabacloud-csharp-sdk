// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class PrecheckYikeAIAppJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

    }

}
