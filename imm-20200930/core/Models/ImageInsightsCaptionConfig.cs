// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ImageInsightsCaptionConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable this feature.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provide a concise title for this monitoring section, capturing the core subject and key event. Keep the title within 10 characters.</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
