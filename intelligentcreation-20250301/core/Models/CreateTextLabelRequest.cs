// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20250301.Models
{
    public class CreateTextLabelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;textID&quot;: &quot;12345&quot;, &quot;type&quot;:&quot;dialogue&quot;, &quot;text&quot;: &quot;您好&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("LabelTemplateId")]
        [Validation(Required=false)]
        public string LabelTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1241148226163200</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
